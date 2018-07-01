using SwearyWeather.helpers;
using SwearyWeather.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwearyWeather
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Purpose: Begin search if the user has given us a location name to work with

            if (txtLocation.Text != "")
                GetLocationMatches(txtLocation.Text);

        }

        private void GetLocationMatches(string location)
        {

            //Purpose: Populates location combolist with those matching users text, selecting first as default

            Windows.LoadingState(true, this);

            List<WeatherLocation> locations = Feeds.GetWeatherLocations(location);

            if (locations== null) {
                MessageBox.Show("Weather service not found, please check your web connection");
                goto Leave;
            }

            listboxLocations.Visible = false;

            switch (locations.Count) {
            
                case 0:
                    txtLocation.Text = "Try another location";
                    break;
                case 1:
                    SetChosenLocation(locations[0]);
                    break;
                default:

                    listboxLocations.DataSource = locations;
                    listboxLocations.DisplayMember = "Title";
                    listboxLocations.ValueMember = "woeid";
                    listboxLocations.Visible = true;
                    break;

            }

            Leave:
            Windows.LoadingState(false, this);

        }

        private void SetChosenLocation(WeatherLocation weatherlocation) {

            //Purpose: Saves new locationid to settings and closes this settings form

            GlobalConfig.WeatherLocation = weatherlocation;
            this.Close();

        }

        private void listboxLocations_DoubleClick(object sender, EventArgs e)
        {

            if (listboxLocations.SelectedItem == null)
                return;

            listboxLocations.Visible = false;
            WeatherLocation location = (WeatherLocation)listboxLocations.SelectedItem;
            SetChosenLocation(location);
        }

    }

}