using System.Windows.Forms;
using System.Drawing;

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
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Label lblReportDesc;
        private System.Windows.Forms.GroupBox grpEvents;
        private System.Windows.Forms.Label lblEventsDesc;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblStatusDesc;


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
            this.mainTableLayout = new TableLayoutPanel();
            this.grpReport = new GroupBox();
            this.lblReportDesc = new Label();
            this.grpEvents = new GroupBox();
            this.lblEventsDesc = new Label();
            this.grpStatus = new GroupBox();
            this.lblStatusDesc = new Label();

            this.headerPanel.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.grpEvents.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();

            // headerPanel
            headerPanel.BackColor = Color.SteelBlue;
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 80);
            headerPanel.TabIndex = 0;

            // lblTitle
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Municipal Services Portal";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // mainTableLayout
            mainTableLayout.ColumnCount = 3;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            mainTableLayout.Controls.Add(grpReport, 0, 0);
            mainTableLayout.Controls.Add(grpEvents, 1, 0);
            mainTableLayout.Controls.Add(grpStatus, 2, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 80);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.Padding = new Padding(20);
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.TabIndex = 1;

            // grpReport
            grpReport.Controls.Add(lblReportDesc);
            grpReport.Controls.Add(btnReportIssue);
            grpReport.Dock = DockStyle.Fill;
            grpReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpReport.Location = new Point(23, 23);
            grpReport.Name = "grpReport";
            grpReport.Padding = new Padding(10);
            grpReport.Size = new Size(278, 324);
            grpReport.TabIndex = 0;
            grpReport.TabStop = false;
            grpReport.Text = "Report an Issue";

            // lblReportDesc
            lblReportDesc.Dock = DockStyle.Fill;
            lblReportDesc.Font = new Font("Segoe UI", 10F);
            lblReportDesc.Location = new Point(10, 32);
            lblReportDesc.Name = "lblReportDesc";
            lblReportDesc.Padding = new Padding(5);
            lblReportDesc.Size = new Size(258, 232);
            lblReportDesc.TabIndex = 1;
            lblReportDesc.Text = "Submit a new report for municipal problems.";

            // btnReportIssue
            btnReportIssue.BackColor = Color.FromArgb(222, 41, 18);
            btnReportIssue.Dock = DockStyle.Bottom;
            btnReportIssue.FlatAppearance.BorderSize = 0;
            btnReportIssue.FlatStyle = FlatStyle.Flat;
            btnReportIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportIssue.ForeColor = Color.White;
            btnReportIssue.Location = new Point(10, 264);
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.Size = new Size(258, 50);
            btnReportIssue.TabIndex = 0;
            btnReportIssue.Text = "New Report";
            btnReportIssue.UseVisualStyleBackColor = false;
            btnReportIssue.Click += btnReportIssue_Click;

            // grpEvents
            grpEvents.Controls.Add(lblEventsDesc);
            grpEvents.Controls.Add(btnLocalEvents);
            grpEvents.Dock = DockStyle.Fill;
            grpEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpEvents.Location = new Point(307, 23);
            grpEvents.Name = "grpEvents";
            grpEvents.Padding = new Padding(10);
            grpEvents.Size = new Size(278, 324);
            grpEvents.TabIndex = 1;
            grpEvents.TabStop = false;
            grpEvents.Text = "Local Events";

            // lblEventsDesc
            lblEventsDesc.Dock = DockStyle.Fill;
            lblEventsDesc.Font = new Font("Segoe UI", 10F);
            lblEventsDesc.Location = new Point(10, 32);
            lblEventsDesc.Name = "lblEventsDesc";
            lblEventsDesc.Padding = new Padding(5);
            lblEventsDesc.Size = new Size(258, 232);
            lblEventsDesc.TabIndex = 1;
            lblEventsDesc.Text = "Find out about upcoming community meetings, community events and public announcements.";

            // btnLocalEvents
            btnLocalEvents.BackColor = Color.FromArgb(255, 182, 18); 
            btnLocalEvents.Dock = DockStyle.Bottom;
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLocalEvents.ForeColor = Color.Black;
            btnLocalEvents.Location = new Point(10, 264);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(258, 50);
            btnLocalEvents.TabIndex = 0;
            btnLocalEvents.Text = "View Events";
            btnLocalEvents.UseVisualStyleBackColor = false;
            btnLocalEvents.Click += btnLocalEvents_Click;

            // grpStatus
            grpStatus.Controls.Add(lblStatusDesc);
            grpStatus.Controls.Add(btnServiceStatus);
            grpStatus.Dock = DockStyle.Fill;
            grpStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpStatus.Location = new Point(591, 23);
            grpStatus.Name = "grpStatus";
            grpStatus.Padding = new Padding(10);
            grpStatus.Size = new Size(286, 324);
            grpStatus.TabIndex = 2;
            grpStatus.TabStop = false;
            grpStatus.Text = "Service Status";

            // lblStatusDesc
            lblStatusDesc.Dock = DockStyle.Fill;
            lblStatusDesc.Font = new Font("Segoe UI", 10F);
            lblStatusDesc.Location = new Point(10, 32);
            lblStatusDesc.Name = "lblStatusDesc";
            lblStatusDesc.Padding = new Padding(5);
            lblStatusDesc.Size = new Size(266, 232);
            lblStatusDesc.TabIndex = 1;
            lblStatusDesc.Text = "Track the progress of your submitted service requests.";

            // btnServiceStatus
            btnServiceStatus.BackColor = Color.FromArgb(0, 94, 184); 
            btnServiceStatus.Dock = DockStyle.Bottom;
            btnServiceStatus.FlatAppearance.BorderSize = 0;
            btnServiceStatus.FlatStyle = FlatStyle.Flat;
            btnServiceStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnServiceStatus.ForeColor = Color.White;
            btnServiceStatus.Location = new Point(10, 264);
            btnServiceStatus.Name = "btnServiceStatus";
            btnServiceStatus.Size = new Size(266, 50);
            btnServiceStatus.TabIndex = 0;
            btnServiceStatus.Text = "Check Status";
            btnServiceStatus.UseVisualStyleBackColor = false;
            btnServiceStatus.Click += btnServiceStatus_Click;

            // MainMenu
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 450);
            Controls.Add(mainTableLayout);
            Controls.Add(headerPanel);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            headerPanel.ResumeLayout(false);
            mainTableLayout.ResumeLayout(false);
            grpReport.ResumeLayout(false);
            grpEvents.ResumeLayout(false);
            grpStatus.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}


/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/