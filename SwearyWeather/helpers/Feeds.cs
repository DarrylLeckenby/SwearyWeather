using Newtonsoft.Json;
using SwearyWeather.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SwearyWeather.helpers;
using Newtonsoft.Json.Linq;

namespace SwearyWeather.helpers
{

    public class Feeds
    {

        public static string RequestFeedData(string url)
        {

            //Purpose: Returns a json get response (as string) from a given url

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                httpWebRequest.ContentType = "text/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception e) {
                return "";
            }

        }

        public static List<WeatherLocation> GetWeatherLocations(string location)
        {

            //Purpose: Returns a list of weatherlocations from weather api

            string strURL = "https://www.metaweather.com/api/location/search/?query=" + location;
            return JsonConvert.DeserializeObject<List<WeatherLocation>>(RequestFeedData(strURL));

        }

        public static List<WeatherReport> GetWeatherReports(Int32 id)
        {

            //Purpose: Returns a list of weatherreports from weather api

            string strURL = "https://www.metaweather.com/api/location/" + id;
            string r = RequestFeedData(strURL);

            if (r == "")
                return null;

            Newtonsoft.Json.Linq.JObject j = Newtonsoft.Json.Linq.JObject.Parse(r);


            return JsonConvert.DeserializeObject<List<WeatherReport>>(j["consolidated_weather"].ToString());

        }

    }

}