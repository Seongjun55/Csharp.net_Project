using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeeklyForecast : Form
    {
        string APIKey = "8755aca3fcad3f0fa15174a40f901202";
        private double lon;
        private double lat;
        private bool isCelsius;  // This flag determines the unit (Celsius or Fahrenheit)

        public WeeklyForecast(double lon, double lat)
        {
            InitializeComponent();
            this.lon = lon;
            this.lat = lat;
            getWeeklyForecast();
        }

        void getWeeklyForecast()
        {
            using (WebClient web = new WebClient())
            {
                weeklyFLP.Controls.Clear();

                string url = string.Format(
                   "https://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}&units=metric",
                   "Seoul",  // 우선 "Seoul"로 테스트하세요
                   APIKey);

                try
                {
                    var json = web.DownloadString(url);
                    Forecast5Day forecastData = JsonConvert.DeserializeObject<Forecast5Day>(json);

                    var groupedDays = forecastData.list
                        .GroupBy(item => DateTime.Parse(item.dt_txt).Date)
                        .Take(5); // 최대 5일만 표시

                    foreach (var dayGroup in groupedDays)
                    {
                        double avgTemp = dayGroup.Average(x => x.main.temp);
                        double avgWind = dayGroup.Average(x => x.wind.speed);
                        var firstItem = dayGroup.First();

                        WeeklyForecastUC wkFUC = new WeeklyForecastUC();

                        wkFUC.picWeatherIcon.ImageLocation =
                            "https://openweathermap.org/img/w/" +
                            firstItem.weather[0].icon + ".png";

                        wkFUC.labDT.Text =
                            dayGroup.Key.DayOfWeek.ToString();

                        wkFUC.labRealTemp.Text =
                            "Avg.Temp: " + avgTemp.ToString("0.0") + "°C";

                        wkFUC.labTemperature.Text =
                            "Main weather: " + firstItem.weather[0].main.ToString();

                        wkFUC.labWindSpeed.Text =
                            "Wind speed: " + avgWind.ToString("0.0") + " m/s";

                        wkFUC.labWeatherDescription.Text =
                            firstItem.weather[0].description.ToString();

                        weeklyFLP.Controls.Add(wkFUC);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the weekly weather data. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }

        // Paint 이벤트 핸들러(에러 방지용)
        private void weeklyFLP_Paint(object sender, PaintEventArgs e)
        {
            // No custom painting needed
        }
    }

    // Forecast 데이터 모델 클래스 (이름 충돌 방지)
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
}
