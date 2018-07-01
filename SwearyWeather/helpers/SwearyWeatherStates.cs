using SwearyWeather.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearyWeather.helpers
{
    class SwearyWeatherStates
    {

        public static List<WeatherState> GetSwearyWeatherStates()
        {

            //Purpose: Returns a populated weatherstate list

            List<WeatherState> weatherstates = new List<WeatherState>();
            weatherstates.Add(new WeatherState("Bloody Snowing. Bloody Cold. Kill Me Now.", "sn"));
            weatherstates.Add(new WeatherState("Snow, Snow and more F**cking Snow.", "sn"));
            weatherstates.Add(new WeatherState("Crappy and Sleety", "sl"));
            weatherstates.Add(new WeatherState("Sleet -We are all going to die", "sl"));
            weatherstates.Add(new WeatherState("Hail", "h"));
            weatherstates.Add(new WeatherState("Hail", "h"));
            weatherstates.Add(new WeatherState("Thunderbolds and lightning, very very frightening.", "t"));
            weatherstates.Add(new WeatherState("THUUUUUNDERRR!", "t"));
            weatherstates.Add(new WeatherState("F*cking Raining", "hr"));
            weatherstates.Add(new WeatherState("Heavy Rain... Should have stayed in bed!", "hr"));
            weatherstates.Add(new WeatherState("Slightly P*ssing it down", "lr"));
            weatherstates.Add(new WeatherState("Your might get B*oody wet, light showers!", "lr"));
            weatherstates.Add(new WeatherState("You are not loved today, its raining", "s"));
            weatherstates.Add(new WeatherState("Rain...pfffffft", "s"));
            weatherstates.Add(new WeatherState("Heavy B*loody Cloud", "hc"));
            weatherstates.Add(new WeatherState("Heavy Cloud. Good for vampires though, watch out for that.", "hc"));
            weatherstates.Add(new WeatherState("Light Cloud, so if you are a vampire, you better run", "lc"));
            weatherstates.Add(new WeatherState("Light Cloud, it could be worse.", "lc"));
            weatherstates.Add(new WeatherState("I've nothing to say to you. It's just clear...", "c"));
            weatherstates.Add(new WeatherState("Skies look good, woooooo!", "c"));
            return weatherstates;

        }

    }
}
