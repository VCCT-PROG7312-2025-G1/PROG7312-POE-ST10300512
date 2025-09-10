// MainMenu.Designer.cs
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnReportIssue = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceStatus = new Button();
            this.lblTitle = new Label();
            this.headerPanel = new Panel();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 102, 204); // Municipal blue
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.Controls.Add(this.lblTitle);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "Municipality Services";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
             
            // btnReportIssue - Button to create a report
            
            this.btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnReportIssue.BackColor = Color.FromArgb(0, 153, 76); // green
            this.btnReportIssue.ForeColor = Color.White;
            this.btnReportIssue.FlatStyle = FlatStyle.Flat;
            this.btnReportIssue.FlatAppearance.BorderSize = 0;
            this.btnReportIssue.Location = new Point(280, 120);
            this.btnReportIssue.Size = new Size(240, 60);
            this.btnReportIssue.Text = "📌 Report an Issue";
            this.btnReportIssue.Click += btnReportIssue_Click;
             
            // btnLocalEvents - WIP for Part  (disabled)
            
            this.btnLocalEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnLocalEvents.BackColor = Color.FromArgb(255, 204, 0); // yellow
            this.btnLocalEvents.ForeColor = Color.Black;
            this.btnLocalEvents.FlatStyle = FlatStyle.Flat;
            this.btnLocalEvents.FlatAppearance.BorderSize = 0;
            this.btnLocalEvents.Location = new Point(280, 200);
            this.btnLocalEvents.Size = new Size(240, 60);
            this.btnLocalEvents.Text = "📅 Local Events (Coming Soon)";
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.Click += btnLocalEvents_Click;
             
            // btnServiceStatus - WIP for Part  (disabled)
             
            this.btnServiceStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnServiceStatus.BackColor = Color.FromArgb(220, 53, 69); // red
            this.btnServiceStatus.ForeColor = Color.White;
            this.btnServiceStatus.FlatStyle = FlatStyle.Flat;
            this.btnServiceStatus.FlatAppearance.BorderSize = 0;
            this.btnServiceStatus.Location = new Point(280, 280);
            this.btnServiceStatus.Size = new Size(240, 60);
            this.btnServiceStatus.Text = "⚙️ Service Status (Coming Soon)";
            this.btnServiceStatus.Enabled = false;
             
            // MainMenu
             
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnReportIssue);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnServiceStatus);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
