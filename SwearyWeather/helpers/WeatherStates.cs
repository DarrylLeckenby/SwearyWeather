using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwearyWeather.models;

namespace SwearyWeather.helpers
{
    public class WeatherStates
    {

        public static List<WeatherState> GetWeatherStates()
        {

            //Purpose: Returns a populated weatherstate list

            List<WeatherState> weatherstates = new List<WeatherState>();
            weatherstates.Add(new WeatherState("Snow", "sn"));
            weatherstates.Add(new WeatherState("Sleet", "sl"));
            weatherstates.Add(new WeatherState("Hail", "h"));
            weatherstates.Add(new WeatherState("Thunderstorm", "t"));
            weatherstates.Add(new WeatherState("Heavy Rain", "hr"));
            weatherstates.Add(new WeatherState("Light Rain", "lr"));
            weatherstates.Add(new WeatherState("Showers", "s"));
            weatherstates.Add(new WeatherState("Heavy Cloud", "hc"));
            weatherstates.Add(new WeatherState("Light Cloud", "lc"));
            weatherstates.Add(new WeatherState("Clear", "c"));
            return weatherstates;

        }

    }
}
