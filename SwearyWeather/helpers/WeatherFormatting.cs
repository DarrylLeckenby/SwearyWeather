using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearyWeather.helpers
{
    class WeatherFormatting
    {

        public static string DegreesToCardinal(double degrees)
        {
            string[] caridnals = { "North", "NorthEast", "East", "SouthEast", "South", "SouthWest", "West", "NorthWest", "North" };
            return caridnals[(int)Math.Round(((double)degrees % 360) / 45)];
        }


    }
}
