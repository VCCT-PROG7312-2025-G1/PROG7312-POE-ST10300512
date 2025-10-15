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
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            btnAttach = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            progressBar = new ProgressBar();
            lblEngagement = new Label();
            lstAttachments = new ListBox();
            headerPanel = new Panel();
            lblHeaderTitle = new Label();
            grpDetails = new GroupBox();
            grpAttachments = new GroupBox();

            headerPanel.SuspendLayout();
            grpDetails.SuspendLayout();
            grpAttachments.SuspendLayout();
            SuspendLayout();

            // Header panel
            headerPanel.BackColor = Color.SteelBlue; 
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 70;
            headerPanel.Controls.Add(lblHeaderTitle);

            // Header title
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Text = "Report an Issue";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;

            // GroupBox for Issue details
            grpDetails.Text = "Issue Details";
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.Location = new Point(40, 90);
            grpDetails.Size = new Size(700, 220);
            grpDetails.Controls.Add(lblLocation);
            grpDetails.Controls.Add(txtLocation);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(cmbCategory);
            grpDetails.Controls.Add(lblDescription);
            grpDetails.Controls.Add(rtbDescription);

            // Location label and textbox
            lblLocation.Text = "Location:";
            lblLocation.Location = new Point(20, 35);
            lblLocation.AutoSize = true;

            txtLocation.Location = new Point(120, 32);
            txtLocation.Size = new Size(540, 23);

            // Category label and combo box
            lblCategory.Text = "Category:";
            lblCategory.Location = new Point(20, 75);
            lblCategory.AutoSize = true;

            cmbCategory.Location = new Point(120, 72);
            cmbCategory.Size = new Size(300, 23);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new object[]
            {
                "Sanitation",
                "Roads",
                "Utilities",
                "Public Safety",
                "Other"
            });

            // Description label and rich textbox
            lblDescription.Text = "Description:";
            lblDescription.Location = new Point(20, 115);
            lblDescription.AutoSize = true;

            rtbDescription.Location = new Point(120, 112);
            rtbDescription.Size = new Size(540, 90);

            // GroupBox for Attachments
            grpAttachments.Text = "Attachments";
            grpAttachments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpAttachments.Location = new Point(40, 320);
            grpAttachments.Size = new Size(700, 130);
            grpAttachments.Controls.Add(btnAttach);
            grpAttachments.Controls.Add(lstAttachments);

            // Attach button
            btnAttach.Text = "Attach Images/Documents";
            btnAttach.Font = new Font("Segoe UI", 9F);
            btnAttach.BackColor = Color.SeaGreen; 
            btnAttach.ForeColor = Color.White;
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.FlatAppearance.BorderSize = 0;
            btnAttach.Location = new Point(20, 35);
            btnAttach.Size = new Size(200, 30);
            btnAttach.Click += BtnAttach_Click;

            // Attachments list
            lstAttachments.Location = new Point(240, 30);
            lstAttachments.Size = new Size(440, 80);

            // Submit button
            btnSubmit.Text = "Submit";
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Location = new Point(440, 470);
            btnSubmit.Size = new Size(120, 40);
            btnSubmit.Click += BtnSubmit_Click;

            // Back button
            btnBack.Text = "Back to Main Menu";
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.BackColor = Color.DimGray;
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(580, 470);
            btnBack.Size = new Size(160, 40);
            btnBack.Click += (s, e) => Close();

            // Progress bar and engagement label
            progressBar.Location = new Point(40, 530);
            progressBar.Size = new Size(700, 20);

            lblEngagement.Text = "Your voice matters – complete your report!";
            lblEngagement.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEngagement.Location = new Point(40, 555);
            lblEngagement.AutoSize = true;

            // ReportIssueForm setup
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 600);
            Controls.Add(headerPanel);
            Controls.Add(grpDetails);
            Controls.Add(grpAttachments);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Controls.Add(progressBar);
            Controls.Add(lblEngagement);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Report Issue";

            headerPanel.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            grpAttachments.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/