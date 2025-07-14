namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.Cloud = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labWeatherPrompt = new System.Windows.Forms.Label();
            this.labCloud = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.toggleCtoF = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.labFeelsLike = new System.Windows.Forms.Label();
            this.btnWeeklyForecast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(84, 94);
            this.picIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(118, 85);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 31;
            this.picIcon.TabStop = false;
            // 
            // Cloud
            // 
            this.Cloud.AutoSize = true;
            this.Cloud.BackColor = System.Drawing.Color.Transparent;
            this.Cloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cloud.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Cloud.Location = new System.Drawing.Point(354, 293);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(53, 18);
            this.Cloud.TabIndex = 29;
            this.Cloud.Text = "Cloud:";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labHumidity.Location = new System.Drawing.Point(475, 258);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(34, 18);
            this.labHumidity.TabIndex = 28;
            this.labHumidity.Text = "N/A";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Humidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Humidity.Location = new System.Drawing.Point(354, 258);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(72, 18);
            this.Humidity.TabIndex = 27;
            this.Humidity.Text = "Humidity:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labWindSpeed.Location = new System.Drawing.Point(475, 223);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(34, 18);
            this.labWindSpeed.TabIndex = 26;
            this.labWindSpeed.Text = "N/A";
            // 
            // WindSpeed
            // 
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeed.ForeColor = System.Drawing.SystemColors.MenuText;
            this.WindSpeed.Location = new System.Drawing.Point(354, 223);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(99, 18);
            this.WindSpeed.TabIndex = 25;
            this.WindSpeed.Text = "Wind Speed:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labSunset.Location = new System.Drawing.Point(161, 325);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(34, 18);
            this.labSunset.TabIndex = 24;
            this.labSunset.Text = "N/A";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Sunset.Location = new System.Drawing.Point(88, 325);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(60, 18);
            this.Sunset.TabIndex = 23;
            this.Sunset.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labSunrise.Location = new System.Drawing.Point(161, 293);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(34, 18);
            this.labSunrise.TabIndex = 22;
            this.labSunrise.Text = "N/A";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Sunrise.Location = new System.Drawing.Point(88, 293);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(65, 18);
            this.Sunrise.TabIndex = 21;
            this.Sunrise.Text = "Sunrise:";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labDetails.Location = new System.Drawing.Point(88, 258);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(57, 18);
            this.labDetails.TabIndex = 20;
            this.labDetails.Text = "Details";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labCondition.Location = new System.Drawing.Point(88, 223);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(75, 18);
            this.labCondition.TabIndex = 19;
            this.labCondition.Text = "Condition";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(357, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 29);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TBCity
            // 
            this.TBCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(155, 34);
            this.TBCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(173, 26);
            this.TBCity.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "City:";
            // 
            // labWeatherPrompt
            // 
            this.labWeatherPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labWeatherPrompt.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherPrompt.ForeColor = System.Drawing.SystemColors.Window;
            this.labWeatherPrompt.Location = new System.Drawing.Point(17, 190);
            this.labWeatherPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWeatherPrompt.Name = "labWeatherPrompt";
            this.labWeatherPrompt.Size = new System.Drawing.Size(566, 36);
            this.labWeatherPrompt.TabIndex = 0;
            this.labWeatherPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labCloud
            // 
            this.labCloud.AutoSize = true;
            this.labCloud.BackColor = System.Drawing.Color.Transparent;
            this.labCloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloud.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labCloud.Location = new System.Drawing.Point(475, 293);
            this.labCloud.Name = "labCloud";
            this.labCloud.Size = new System.Drawing.Size(34, 18);
            this.labCloud.TabIndex = 33;
            this.labCloud.Text = "N/A";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.ForeColor = System.Drawing.SystemColors.Window;
            this.labTemp.Location = new System.Drawing.Point(242, 94);
            this.labTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(59, 32);
            this.labTemp.TabIndex = 34;
            this.labTemp.Text = "N/A";
            // 
            // toggleCtoF
            // 
            this.toggleCtoF.BackColor = System.Drawing.Color.Transparent;
            this.toggleCtoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleCtoF.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toggleCtoF.Location = new System.Drawing.Point(406, 110);
            this.toggleCtoF.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.toggleCtoF.Name = "toggleCtoF";
            this.toggleCtoF.Size = new System.Drawing.Size(66, 43);
            this.toggleCtoF.TabIndex = 36;
            this.toggleCtoF.Text = "Change Scale";
            this.toggleCtoF.UseVisualStyleBackColor = false;
            this.toggleCtoF.Click += new System.EventHandler(this.toggleCtoF_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnViewHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHistory.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewHistory.Location = new System.Drawing.Point(487, 14);
            this.btnViewHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(66, 72);
            this.btnViewHistory.TabIndex = 37;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = false;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP.Location = new System.Drawing.Point(189, 348);
            this.FLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(248, 350);
            this.FLP.TabIndex = 38;
            this.FLP.WrapContents = false;
            // 
            // labFeelsLike
            // 
            this.labFeelsLike.AutoSize = true;
            this.labFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labFeelsLike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeelsLike.ForeColor = System.Drawing.SystemColors.Window;
            this.labFeelsLike.Location = new System.Drawing.Point(246, 134);
            this.labFeelsLike.Name = "labFeelsLike";
            this.labFeelsLike.Size = new System.Drawing.Size(34, 18);
            this.labFeelsLike.TabIndex = 40;
            this.labFeelsLike.Text = "N/A";
            // 
            // btnWeeklyForecast
            // 
            this.btnWeeklyForecast.BackColor = System.Drawing.Color.Transparent;
            this.btnWeeklyForecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWeeklyForecast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWeeklyForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyForecast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWeeklyForecast.Location = new System.Drawing.Point(463, 382);
            this.btnWeeklyForecast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWeeklyForecast.Name = "btnWeeklyForecast";
            this.btnWeeklyForecast.Size = new System.Drawing.Size(120, 45);
            this.btnWeeklyForecast.TabIndex = 41;
            this.btnWeeklyForecast.Text = "Weekly Forecast";
            this.btnWeeklyForecast.UseVisualStyleBackColor = false;
            this.btnWeeklyForecast.Click += new System.EventHandler(this.btnWeeklyForecast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 736);
            this.Controls.Add(this.btnWeeklyForecast);
            this.Controls.Add(this.labFeelsLike);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.toggleCtoF);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.labCloud);
            this.Controls.Add(this.labWeatherPrompt);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.WindSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WeatherApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label Cloud;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label WindSpeed;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labWeatherPrompt;
        private System.Windows.Forms.Label labCloud;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Button toggleCtoF;
        private System.Windows.Forms.Button btnViewHistory;
        public System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label labFeelsLike;
        private System.Windows.Forms.Button btnWeeklyForecast;
    }
}

