namespace WeatherApp
{
    partial class WeeklyForecast
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
            this.weeklyFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // weeklyFLP
            // 
            this.weeklyFLP.AutoScroll = true;
            this.weeklyFLP.Location = new System.Drawing.Point(12, 12);
            this.weeklyFLP.Name = "weeklyFLP";
            this.weeklyFLP.Size = new System.Drawing.Size(477, 167);
            this.weeklyFLP.TabIndex = 0;
            this.weeklyFLP.WrapContents = false;
            this.weeklyFLP.Paint += new System.Windows.Forms.PaintEventHandler(this.weeklyFLP_Paint);
            // 
            // WeeklyForecast
            // 
            this.ClientSize = new System.Drawing.Size(503, 191);
            this.Controls.Add(this.weeklyFLP);
            this.Name = "WeeklyForecast";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel weeklyFLP;
    }
}
