using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearyWeather.models
{

    public class WeatherReport
    {

        public float Air_Pressure { get; set; }
        public DateTime Applicable_Date { get; set; }
        public float Humidity { get; set; }
        public Int64 ID { get; set; }
        public Int64 Max_Temp { get; set; }
        public Int64 Min_Temp { get; set; }
        public Int32 Predictability { get; set; }
        public Int64 The_Temp { get; set; }
        public float Visibility { get; set; }
        public WeatherState WeatherState {

            get
            {
                return (from WeatherState in helpers.WeatherStates.GetWeatherStates() where WeatherState.Abbreviation == Weather_State_Abbr select WeatherState).First();
            }

        }

        public WeatherState SwearyWeatherState
        {

            get
            {
                //Get a random sweary weather
                Random rand = new Random();
                int toSkip = rand.Next(0, 2);
                return (from WeatherState in helpers.SwearyWeatherStates.GetSwearyWeatherStates() where WeatherState.Abbreviation == Weather_State_Abbr select WeatherState).Skip(toSkip).Take(1).First();
            }

        }
        public string Weather_State_Abbr { get; set; }
        public string Weather_State_Name { get; set; }
        public string Wind_Direction { get; set; }
        public string Wind_Direction_Compass { get; set; }
        public string Wind_Speed { get; set; }

    }

}