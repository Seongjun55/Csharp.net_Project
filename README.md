# Group Project 2/ Application Development with .NET/ Spring 2023 UTS/ 

A desktop weather application built with C#.NET Windows Forms.  
It utilizes the OpenWeatherMap API to display real-time current weather, weekly forecasts, and hourly forecasts.

---

## 🖥️ Features

✅ **Current Weather Search**  
- Enter a city name to retrieve current weather details, including temperature, weather conditions, icon, humidity, and wind speed.

✅ **Weekly Weather Forecast**  
- Displays weekly average temperature, main weather condition, and wind speed in a dedicated Weekly Forecast window.

✅ **Hourly Forecast (3-hour intervals)**  
- Shows weather forecasts in 3-hour intervals for up to 5 days.

✅ **Celsius/Fahrenheit Toggle**  
- Switch between Celsius and Fahrenheit for temperature and wind speed.

✅ **Search History**  
- Keeps a record of previously searched cities for easy access.

---

## 🔗 API Used

This application uses the [OpenWeatherMap](https://openweathermap.org/) API:

- **Current Weather API**  
  `https://api.openweathermap.org/data/2.5/weather`

- **5-day / 3-hour Forecast API** (free plan)  
  `https://api.openweathermap.org/data/2.5/forecast`

> ⚠️ **Note:**  
> The One Call API requires a paid plan. This application has been updated to use free APIs instead.

---

## ⚙️ Installation & Usage

1. Open the solution in Visual Studio and build the project.
2. Obtain your API Key from OpenWeatherMap and replace the placeholder in `Form1.cs`:

    ```csharp
    string APIKey = "YOUR_API_KEY";
    ```

3. Run the application and enter a city name to search for weather data.

---

## 📁 Project Structure

| File                        | Description |
|-----------------------------|-------------|
| Form1.cs                    | Main form handling current weather, forecast, and search logic. |
| WeeklyForecast.cs           | Form displaying the weekly weather forecast. |
| ForecastUC.cs               | UserControl for displaying hourly forecast items. |
| WeeklyForecastUC.cs         | UserControl for displaying weekly forecast items. |
| SearchHistoryForm.cs        | Displays the search history list. |
| WeatherInfo.cs              | Data models for current weather JSON response. |
| Forecast5Day.cs             | Data models for 5-day forecast JSON response. |

---

## 📄 Changes from Original Code

### ✅ **Removed Paid One Call API**

- **Old Implementation (2 years ago):**
    - The app used the One Call API:
      ```
      https://api.openweathermap.org/data/2.5/onecall
      ```
    - Retrieved **hourly forecast in 1-hour intervals** for up to 48 hours.
    - Also provided daily forecast in the same API call.
    - Required latitude and longitude.
    - Not available for free accounts → caused 401 Unauthorized errors.

- **New Implementation:**
    - Replaced with:
      ```
      https://api.openweathermap.org/data/2.5/forecast?q={city}
      ```
    - Uses city name instead of lat/lon.
    - Provides 5-day forecast in **3-hour intervals**.
    - Free to use under OpenWeatherMap's free plan.

---

### ✅ **Forecast Code Refactoring**

- Replaced dynamic JSON parsing with strongly typed C# classes:
    - Added `Forecast5Day`, `ForecastList`, `ForecastMainInfo`, `ForecastWeatherInfo`, `ForecastWindInfo`

- Updated forecast retrieval logic:
    - Groups 3-hour forecast data by date for weekly averages.
    - Handles API errors gracefully with proper try-catch logic.

---

### ✅ **Temperature Unit Handling**

- Now supports both metric and imperial units based on user preference:
    - Celsius → Fahrenheit conversion.
    - m/s → mi/h conversion for wind speed.

---

### ✅ **Removed One Call Daily Block Logic**

- The original code relied on the `daily` block from the One Call API for weekly forecasts.
- Now computes daily averages manually from 3-hour data provided by the free forecast API.

---

## 📸 Screenshots
1. Main screen
<img width="588" height="759" alt="메인화면" src="https://github.com/user-attachments/assets/7e45321d-95ed-4499-8acc-d40ff1a9fe6c" />

2. Forecast screen
<img width="588" height="759" alt="메인화면" src="https://github.com/user-attachments/assets/033af3c2-fcd9-4a77-ac9e-428a777fdbe0" />

3. Search History
<img width="847" height="763" alt="Search history" src="https://github.com/user-attachments/assets/f6985abd-0393-4146-9828-8ba1cbc6a8a8" />

4. Change Scale
<img width="591" height="762" alt="Change Scale" src="https://github.com/user-attachments/assets/d6e2a26d-1a5e-4d7d-ace8-f5dd28f81f56" />

5. Error Handling
<img width="585" height="762" alt="Error Handling" src="https://github.com/user-attachments/assets/879ec12d-ac21-4a4c-992a-a8c18d30cc1f" />

---

## 💡 Future Improvements


- Secure storage for API Key.
- Change the forecast time to local time
- Loading animations during API calls.
- Support for additional weather metrics (UV index, air quality, etc)


---

## ℹ️ License & Appendix

This project was created for personal learning and non-commercial use.  
Please comply with the OpenWeatherMap terms and license.

Icon list (https://openweathermap.org/weather-conditions)
<img width="623" height="690" alt="image" src="https://github.com/user-attachments/assets/41b8615e-db11-44f2-be77-dffb9e10e14d" />


