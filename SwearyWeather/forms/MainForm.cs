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

namespace SwearyWeather.forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Windows.OpenSettings();
            GetWeatherReports(GlobalConfig.WeatherLocation.woeid);
            timer1.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            Windows.OpenSettings();
            GetWeatherReports(GlobalConfig.WeatherLocation.woeid);

        }

        void GetWeatherReports(Int32 id)
        {

            //Initiates the request and display of weather reports based on a location woeid

            try
            {

                Windows.LoadingState(true, this);

                List<WeatherReport> weatherreports = Feeds.GetWeatherReports(id);

                EnableInterface(true);
                StringBuilder output = new StringBuilder();


                foreach (WeatherReport wr in weatherreports)
                {

                    if (wr.Applicable_Date.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {

                        pictureboxWeatherIcon.Load(wr.WeatherState.Icon);
                        lblWeatherAdvice.Text = "The Weather in " + GlobalConfig.WeatherLocation.title + " today is " + wr.SwearyWeatherState.Name;
                        lblMinTemp.Text = "Min Temp: " + wr.Min_Temp + "C";
                        lblMaxTemp.Text = "Max Temp: " + wr.Max_Temp + "C";
                        lblTemp.Text = "Temp: " + wr.The_Temp + "C";
                        lblWindSpeed.Text = "Wind Speed: " + Convert.ToDecimal(wr.Wind_Speed).ToString("0.00") + "Mph";
                        lblWindDirection.Text = "Wind Direction: " + WeatherFormatting.DegreesToCardinal(Convert.ToDouble(wr.Wind_Direction));
                        lblAirPressure.Text = "Air Pressure: " + wr.Air_Pressure.ToString() + " mbar";
                        lblHumidity.Text = "Humidity: " + wr.Humidity.ToString() + "%";
                        lblVisibility.Text = "Visibility: " + wr.Visibility.ToString("0.00") + " miles";

                    }
                    else
                    {

                        output.AppendLine("<div style=\"position:relative; font-size:22px; width:50px; float:left; padding:20px;\">");
                        output.AppendLine("<b>" + wr.Applicable_Date.DayOfWeek + "</b><br />");
                        output.AppendLine("<img src=\"" + wr.WeatherState.Icon + "\" />");
                        output.AppendLine(wr.Weather_State_Name);
                        output.AppendLine("</div>");

                    }

                }

                DisplayHtml(output.ToString());
                Windows.LoadingState(false, this);

            }

            catch (Exception e) {

                EnableInterface(false);
                return;

            }

        }

        void DisplayHtml(string html)
        {
            //Purpose: Display a given HTML string in a browser control

            Browser.Navigate("about:blank");

            if (Browser.Document != null)
                Browser.Document.Write(string.Empty);

            Browser.DocumentText = html;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            lblWeatherAdvice.Width = this.Width - 277;
            lblWeatherAdvice.Height = this.Height / 2;
            Browser.Top = this.Height - 300;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetWeatherReports(GlobalConfig.WeatherLocation.woeid);
        }

        public void EnableInterface(Boolean show) {

            panel1.Visible = show;
            pictureboxWeatherIcon.Visible = show;
            Browser.Visible = show;
            Windows.LoadingState(show, this);

            if (!show)
                lblWeatherAdvice.Text = "Sorry the weather service could not be contacted";

        }

    }

}