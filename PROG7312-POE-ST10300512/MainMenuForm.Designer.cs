namespace PROG7312_POE_ST10300512
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel headerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportIssue = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceStatus = new Button();
            this.lblTitle = new Label();
            this.headerPanel = new Panel();
            this.SuspendLayout();

            // headerPanel
            headerPanel.BackColor = Color.SteelBlue;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 80;
            headerPanel.Controls.Add(lblTitle);

            // lblTitle
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Text = "Municipality Services";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Report Issue button
            btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportIssue.BackColor = Color.SeaGreen;
            btnReportIssue.ForeColor = Color.White;
            btnReportIssue.FlatStyle = FlatStyle.Flat;
            btnReportIssue.FlatAppearance.BorderSize = 0;
            btnReportIssue.Location = new Point(280, 120);
            btnReportIssue.Size = new Size(240, 60);
            btnReportIssue.Text = "Report an Issue";
            btnReportIssue.Click += btnReportIssue_Click;

            // Local Events button (Part 2)
            btnLocalEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLocalEvents.BackColor = Color.Gold;
            btnLocalEvents.ForeColor = Color.Black;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.Location = new Point(280, 200);
            btnLocalEvents.Size = new Size(240, 60);
            btnLocalEvents.Text = "Local Events";
            btnLocalEvents.Click += btnLocalEvents_Click;

            // Service Status button (Part 3 - WIP)
            btnServiceStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServiceStatus.BackColor = Color.IndianRed;
            btnServiceStatus.ForeColor = Color.White;
            btnServiceStatus.FlatStyle = FlatStyle.Flat;
            btnServiceStatus.FlatAppearance.BorderSize = 0;
            btnServiceStatus.Location = new Point(280, 280);
            btnServiceStatus.Size = new Size(240, 60);
            btnServiceStatus.Text = "Service Status (Coming Soon)";
            btnServiceStatus.Enabled = false;

            // MainMenu
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(headerPanel);
            Controls.Add(btnReportIssue);
            Controls.Add(btnLocalEvents);
            Controls.Add(btnServiceStatus);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";

            ResumeLayout(false);
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/
