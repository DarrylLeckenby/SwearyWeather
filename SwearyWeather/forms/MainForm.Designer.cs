namespace SwearyWeather.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pictureboxWeatherIcon = new System.Windows.Forms.PictureBox();
            this.lblWeatherAdvice = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblAirPressure = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWeatherIcon)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(280, 320);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScrollBarsEnabled = false;
            this.Browser.Size = new System.Drawing.Size(825, 250);
            this.Browser.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(112, 34);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Change Location";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureboxWeatherIcon
            // 
            this.pictureboxWeatherIcon.Location = new System.Drawing.Point(297, 43);
            this.pictureboxWeatherIcon.Name = "pictureboxWeatherIcon";
            this.pictureboxWeatherIcon.Size = new System.Drawing.Size(120, 120);
            this.pictureboxWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxWeatherIcon.TabIndex = 3;
            this.pictureboxWeatherIcon.TabStop = false;
            // 
            // lblWeatherAdvice
            // 
            this.lblWeatherAdvice.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherAdvice.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherAdvice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWeatherAdvice.Location = new System.Drawing.Point(277, 166);
            this.lblWeatherAdvice.Margin = new System.Windows.Forms.Padding(0);
            this.lblWeatherAdvice.Name = "lblWeatherAdvice";
            this.lblWeatherAdvice.Size = new System.Drawing.Size(860, 298);
            this.lblWeatherAdvice.TabIndex = 4;
            this.lblWeatherAdvice.Text = "Weather advice displays here";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtons.Controls.Add(this.btnSettings);
            this.PanelButtons.Controls.Add(this.btnExit);
            this.PanelButtons.Location = new System.Drawing.Point(872, 527);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(239, 46);
            this.PanelButtons.TabIndex = 5;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed.Location = new System.Drawing.Point(16, 99);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(105, 23);
            this.lblWindSpeed.TabIndex = 6;
            this.lblWindSpeed.Text = "Wind Speed";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.ForeColor = System.Drawing.Color.White;
            this.lblMinTemp.Location = new System.Drawing.Point(16, 71);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(84, 23);
            this.lblMinTemp.TabIndex = 7;
            this.lblMinTemp.Text = "MinTemp";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.ForeColor = System.Drawing.Color.White;
            this.lblMaxTemp.Location = new System.Drawing.Point(16, 43);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(91, 23);
            this.lblMaxTemp.TabIndex = 8;
            this.lblMaxTemp.Text = "Max Temp";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(16, 15);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(85, 23);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "The Temp";
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindDirection.ForeColor = System.Drawing.Color.White;
            this.lblWindDirection.Location = new System.Drawing.Point(16, 127);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(129, 23);
            this.lblWindDirection.TabIndex = 10;
            this.lblWindDirection.Text = "Wind Direction";
            // 
            // lblAirPressure
            // 
            this.lblAirPressure.AutoSize = true;
            this.lblAirPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirPressure.ForeColor = System.Drawing.Color.White;
            this.lblAirPressure.Location = new System.Drawing.Point(16, 155);
            this.lblAirPressure.Name = "lblAirPressure";
            this.lblAirPressure.Size = new System.Drawing.Size(108, 23);
            this.lblAirPressure.TabIndex = 11;
            this.lblAirPressure.Text = "Air Pressure";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.White;
            this.lblHumidity.Location = new System.Drawing.Point(16, 183);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(83, 23);
            this.lblHumidity.TabIndex = 12;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.ForeColor = System.Drawing.Color.White;
            this.lblVisibility.Location = new System.Drawing.Point(16, 211);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(80, 23);
            this.lblVisibility.TabIndex = 13;
            this.lblVisibility.Text = "Visibility";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMinTemp);
            this.panel1.Controls.Add(this.lblVisibility);
            this.panel1.Controls.Add(this.lblHumidity);
            this.panel1.Controls.Add(this.lblMaxTemp);
            this.panel1.Controls.Add(this.lblTemp);
            this.panel1.Controls.Add(this.lblAirPressure);
            this.panel1.Controls.Add(this.lblWindDirection);
            this.panel1.Controls.Add(this.lblWindSpeed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 585);
            this.panel1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureboxWeatherIcon);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.lblWeatherAdvice);
            this.Controls.Add(this.Browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWeatherIcon)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureboxWeatherIcon;
        private System.Windows.Forms.Label lblWeatherAdvice;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label lblAirPressure;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}