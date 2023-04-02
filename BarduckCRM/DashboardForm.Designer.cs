namespace BarduckCRM
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BarduckCRM.Bekleyiniz), true, true);
            this.dashboardPanel1 = new BarduckCRM.DashboardPanel();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // dashboardPanel1
            // 
            this.dashboardPanel1._DashboardID = -1;
            this.dashboardPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel1.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel1.Name = "dashboardPanel1";
            this.dashboardPanel1.Size = new System.Drawing.Size(853, 527);
            this.dashboardPanel1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 527);
            this.Controls.Add(this.dashboardPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private BarduckCRM.DashboardPanel dashboardPanel1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}