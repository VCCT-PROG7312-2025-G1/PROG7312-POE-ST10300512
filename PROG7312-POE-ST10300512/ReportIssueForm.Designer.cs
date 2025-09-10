namespace PROG7312_POE_ST10300512
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.GroupBox grpAttachments;

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
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.grpAttachments = new System.Windows.Forms.GroupBox();
            this.headerPanel.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpAttachments.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 70;
            this.headerPanel.Controls.Add(this.lblHeaderTitle);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Text = "Report an Issue";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            // grpDetails - Group for "Issue" components
             
            this.grpDetails.Text = "Issue Details";
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(40, 90);
            this.grpDetails.Size = new System.Drawing.Size(700, 220);
            this.grpDetails.Controls.Add(this.lblLocation);
            this.grpDetails.Controls.Add(this.txtLocation);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.cmbCategory);
            this.grpDetails.Controls.Add(this.lblDescription);
            this.grpDetails.Controls.Add(this.rtbDescription);
            // 
            // lblLocation
            // 
            this.lblLocation.Text = "Location:";
            this.lblLocation.Location = new System.Drawing.Point(20, 35);
            this.lblLocation.AutoSize = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 32);
            this.txtLocation.Size = new System.Drawing.Size(540, 23);
            // 
            // lblCategory
            // 
            this.lblCategory.Text = "Category:";
            this.lblCategory.Location = new System.Drawing.Point(20, 75);
            this.lblCategory.AutoSize = true;
             
            // cmbCategory - Preset of Report issues
             
            this.cmbCategory.Location = new System.Drawing.Point(120, 72);
            this.cmbCategory.Size = new System.Drawing.Size(300, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
                "Sanitation",
                "Roads",
                "Utilities",
                "Public Safety",
                "Other"});
             
            // lblDescription
             
            this.lblDescription.Text = "Description:";
            this.lblDescription.Location = new System.Drawing.Point(20, 115);
            this.lblDescription.AutoSize = true;
             
            // rtbDescription
             
            this.rtbDescription.Location = new System.Drawing.Point(120, 112);
            this.rtbDescription.Size = new System.Drawing.Size(540, 90);
             
            // grpAttachments - Grouped the "Attachment" components
             
            this.grpAttachments.Text = "Attachments";
            this.grpAttachments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAttachments.Location = new System.Drawing.Point(40, 320);
            this.grpAttachments.Size = new System.Drawing.Size(700, 130);
            this.grpAttachments.Controls.Add(this.btnAttach);
            this.grpAttachments.Controls.Add(this.lstAttachments);
             
            // btnAttach - Allows the user to select a file to attach
             
            this.btnAttach.Text = "Attach Images/Documents";
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.Location = new System.Drawing.Point(20, 35);
            this.btnAttach.Size = new System.Drawing.Size(200, 30);
            this.btnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
             
            // lstAttachments - Attaches the File to the report
             
            this.lstAttachments.Location = new System.Drawing.Point(240, 30);
            this.lstAttachments.Size = new System.Drawing.Size(440, 80);
            
            // btnSubmit - Submits the Report
            
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Location = new System.Drawing.Point(440, 470);
            this.btnSubmit.Size = new System.Drawing.Size(120, 40);
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);

            // btnBack - allows the user to go back to the main menu

            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new System.Drawing.Point(580, 470);
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.Click += new System.EventHandler((s, e) => this.Close());

            // progressBar  - To show the user how far they are with completing the Report

            this.progressBar.Location = new System.Drawing.Point(40, 530);
            this.progressBar.Size = new System.Drawing.Size(700, 20);
            // 
            // lblEngagement
            // 
            this.lblEngagement.Text = "Your voice matters, complete the Report.";
            this.lblEngagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEngagement.Location = new System.Drawing.Point(40, 555);
            this.lblEngagement.AutoSize = true;
            // 
            // ReportIssueForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpAttachments);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblEngagement);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Issue";
            this.headerPanel.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpAttachments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
