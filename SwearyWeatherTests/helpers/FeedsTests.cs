using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwearyWeather.helpers;
using SwearyWeather.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearyWeather.helpers.Tests
{
    [TestClass()]
    public class FeedsTests
    {

        [TestMethod()]
        public void GetWeatherLocations()
        {
            List<WeatherLocation> locations = SwearyWeather.helpers.Feeds.GetWeatherLocations("York");
            Assert.IsNotNull(locations, "Weather locations request was not successfull");
        }

        [TestMethod()]
        public void GetWeatherReports()
        {

            List<WeatherReport> reports = SwearyWeather.helpers.Feeds.GetWeatherReports(41415);
            Assert.IsNotNull(reports, "Weather reports request was not successfull");
        }



    }
}