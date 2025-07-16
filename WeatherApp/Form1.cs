using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            isCelsius = true; // Set Celsius as default

            //Initial setup for buttons, turn them off
            toggleCtoF.Enabled = false;
            btnViewHistory.Enabled = false;
            btnWeeklyForecast.Enabled = false;
    }
        //Grab APIkey from openweathermap
        string APIKey = "8755aca3fcad3f0fa15174a40f901202";

        //Initialise a list that will store user's search
        List<string> searchHistory = new List<string>();
        double lon;
        double lat;
        private bool isCelsius;  // This flag determines the unit (Celsius or Fahrenheit)

        //Call getWeather method when interacted with
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather() // Call current weather data
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    //Setting up which unit should be used.
                    string tempUnit = isCelsius ? "metric" : "imperial";

                    //Initialse variable and use the URL for weather data retrieval
                    //Uses city input from user and API key directly from openweathermap
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units={2}", TBCity.Text, APIKey, tempUnit);

                    // Download JSON data from the API
                    var json = web.DownloadString(url);

                    // Deserialize the JSON data into WeatherInfo.root object
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    // Update the UI elements with weather information
                    picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labCondition.Text = Info.weather[0].main;
                    labDetails.Text = Info.weather[0].description;
                    labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                    //Conversion of the wind speed from metres/s or miles/h
                    if (isCelsius)
                    {
                        labWindSpeed.Text = Info.wind.speed.ToString("0.##") + " m/s";
                    }
                    else
                    {
                        labWindSpeed.Text = (Info.wind.speed * 2.23694).ToString("0.##") + " mi/h";
                    }
                    // Update the UI elements with weather information
                    labCloud.Text = Info.clouds.all.ToString() +"%";
                    labHumidity.Text = Info.main.humidity.ToString() +"%";
                    labTemp.Text = Math.Round(Info.main.temp).ToString() + (isCelsius ? "°C" : "°F");
                    labFeelsLike.Text = "Feels Like: " + Math.Round(Info.main.feels_like).ToString() + (isCelsius ? "°C" : "°F");

                    //Setup for longitude and latitude
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;

                    // Call the method to display weather prompts
                    weatherPrompts(Info.weather[0].main);
                    string searchedCity = TBCity.Text.ToLower();

                    //Duplicate checking, if a valid city is not already on the list, append it
                    if (!searchHistory.Contains(searchedCity))
                    {
                        searchHistory.Add(searchedCity);
                    }

                    //Enable the buttons if this getWeather is called
                    btnWeeklyForecast.Enabled = true;
                    toggleCtoF.Enabled = true;
                    btnViewHistory.Enabled = true;
                    getForecast();
                }

                // Checking valid city from API
                catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
                {
                    // City not found on the API's server
                    MessageBox.Show("City not found. Please ensure you've entered a valid city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toggleCtoF.Enabled = false;
                    btnViewHistory.Enabled = false;
                    btnWeeklyForecast.Enabled = false;
                }
            }
        }
        //Method for the Daily Forecast UI
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string tempUnit = isCelsius ? "metric" : "imperial";

                    string url = string.Format(
                        "https://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}&units={2}",
                        TBCity.Text,
                        APIKey,
                        tempUnit);

                    var json = web.DownloadString(url);
                    Forecast5Day forecastData = JsonConvert.DeserializeObject<Forecast5Day>(json);

                    FLP.Controls.Clear();

                    // ▶ 여기부터 수정된 부분 ◀
                    var forecasts = forecastData.list
                        .Where(item =>
                            DateTime.Parse(item.dt_txt).ToLocalTime() > DateTime.Now)
                        .Take(10)
                        .ToList();

                    foreach (var forecast in forecasts)
                    {
                        ForecastUC FUC = new ForecastUC();

                        FUC.picWeatherIcon.ImageLocation =
                            "https://openweathermap.org/img/w/" +
                            forecast.weather[0].icon + ".png";

                        FUC.labDT.Text =
                            DateTime.SpecifyKind(
                                DateTime.Parse(forecast.dt_txt),
                                DateTimeKind.Utc
                                                 ).ToLocalTime().ToString("HH:mm");


                        double windSpeed = forecast.wind.speed;

                        if (!isCelsius)
                        {
                            windSpeed = windSpeed * 2.23694; // m/s → mi/h
                        }

                        FUC.labWindSpeed.Text =
                            windSpeed.ToString("0.##") +
                            (isCelsius ? " m/s" : " mi/h");

                        FUC.labWeatherDescription.Text =
                            forecast.weather[0].description;

                        FUC.labTemperature.Text =
                            forecast.main.temp.ToString("0.0") +
                            (isCelsius ? "°C" : "°F");

                        FLP.Controls.Add(FUC);
                    }
                }
                catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("City not found. Please ensure you've entered a valid city name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Forecast load error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void weatherPrompts(string labCondition)
        {
            //Switch case, when read weather condition, display accordingly
            switch (labCondition.ToLower())
            {
                case "clear":
                    labWeatherPrompt.Text = "Beautiful day to go outside!";
                    break;
                case "clouds":
                    labWeatherPrompt.Text = "Good day to go outside but Cloudy today!";
                    break;
                case "rain":
                    labWeatherPrompt.Text = "Bring an Umbrella!, chances of rain is high!";
                    break;
                case "thunderstorm":
                    labWeatherPrompt.Text = "Beware of thunderstorms!, Refrain from going out.";
                    break;
                case "snow":
                    labWeatherPrompt.Text = "Wear thick clothing today, i-it'll b-be c-cold t-today!";
                    break;
                case "mist":
                    labWeatherPrompt.Text = "Bring an Umbrella!, light showers and fog may occur.";
                    break;
                default:
                    labWeatherPrompt.Text = $"Weather condition '{labCondition}' not recognized!";
                    break;

            }
        }


        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime(); // Creating the base date time object
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        private void toggleCtoF_Click(object sender, EventArgs e)
        {
            // Convert the current displayed temperature
            double currentTemp = Convert.ToDouble(labTemp.Text.Substring(0, labTemp.Text.Length - 2)); // Removes the last two characters (either "°C" or "°F")

            if (isCelsius)
            {
                // Convert Celsius to Fahrenheit
                currentTemp = (currentTemp * 9 / 5) + 32;
                labTemp.Text = Math.Round(currentTemp).ToString() + "°F";
            }
            else
            {
                // Convert Fahrenheit to Celsius
                currentTemp = (currentTemp - 32) * 5 / 9;
                labTemp.Text = Math.Round(currentTemp).ToString() + "°C";
            }
            // Convert wind speed scale
            double currentWindSpeed = Convert.ToDouble(labWindSpeed.Text.Split(' ')[0]);

            if (isCelsius)
            {
                labWindSpeed.Text = (currentWindSpeed * 2.23694).ToString("0.##") + " mi/h";
            }
            else
            {
                labWindSpeed.Text = (currentWindSpeed / 2.23694).ToString("0.##") + " m/s";
            }

            // Toggle the flag
            isCelsius = !isCelsius;

            getForecast();
        }

        //Open the History of Search
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            //Create new object of history form
            SearchHistoryForm historyForm = new SearchHistoryForm(this);

            //append the user's query into the list box
            historyForm.lstSearchHistory.Items.AddRange(searchHistory.ToArray());
            //Display in new window the form
            historyForm.Show();
        }

        private void btnWeeklyForecast_Click(object sender, EventArgs e)
        {
            //Create new object of weeklyforecast form, pass lon and lat aswell
            WeeklyForecast weeklyForecast = new WeeklyForecast(lon, lat, isCelsius);
            //Display in new window this form
            weeklyForecast.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labWeatherPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}
public class Forecast5Day
{
    public List<ForecastList> list { get; set; }
}

public class ForecastList
{
    public ForecastMainInfo main { get; set; }
    public List<ForecastWeatherInfo> weather { get; set; }
    public ForecastWindInfo wind { get; set; }
    public string dt_txt { get; set; }
}

public class ForecastMainInfo
{
    public double temp { get; set; }
}

public class ForecastWeatherInfo
{
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class ForecastWindInfo
{
    public double speed { get; set; }
}
