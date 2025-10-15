namespace PROG7312_POE_ST10300512
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel hdrPanel;
        private System.Windows.Forms.Label lblEventsTitle;
        private System.Windows.Forms.GroupBox grpEventFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox chkFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.CheckBox chkTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblRecom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            hdrPanel = new Panel();
            lblEventsTitle = new Label();
            grpEventFilters = new GroupBox();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            chkFrom = new CheckBox();
            dtFrom = new DateTimePicker();
            chkTo = new CheckBox();
            dtTo = new DateTimePicker();
            btnSearch = new Button();
            lstResults = new ListBox();
            btnBack = new Button();
            lblHint = new Label();
            lblRecom = new Label();
            hdrPanel.SuspendLayout();
            grpEventFilters.SuspendLayout();
            SuspendLayout();

            // hdrPanel
            hdrPanel.BackColor = Color.SteelBlue;
            hdrPanel.Controls.Add(lblEventsTitle);
            hdrPanel.Dock = DockStyle.Top;
            hdrPanel.Location = new Point(0, 0);
            hdrPanel.Name = "hdrPanel";
            hdrPanel.Size = new Size(800, 70);
            hdrPanel.TabIndex = 0;

            // lblEventsTitle
            lblEventsTitle.Dock = DockStyle.Fill;
            lblEventsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEventsTitle.ForeColor = Color.White;
            lblEventsTitle.Text = "Local Events & Announcements";
            lblEventsTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpEventFilters
            grpEventFilters.Controls.Add(txtSearch);
            grpEventFilters.Controls.Add(cmbCategory);
            grpEventFilters.Controls.Add(chkFrom);
            grpEventFilters.Controls.Add(dtFrom);
            grpEventFilters.Controls.Add(chkTo);
            grpEventFilters.Controls.Add(dtTo);
            grpEventFilters.Controls.Add(btnSearch);
            grpEventFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEventFilters.Location = new Point(40, 90);
            grpEventFilters.Size = new Size(720, 110);
            grpEventFilters.Text = "Search";

            // txtSearch
            txtSearch.Location = new Point(20, 30);
            txtSearch.Size = new Size(280, 25);
            txtSearch.PlaceholderText = "Search by name, description or location of event";

            // cmbCategory
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(320, 30);
            cmbCategory.Size = new Size(160, 25);

            // chkFrom
            chkFrom.AutoSize = true;
            chkFrom.Location = new Point(20, 70);
            chkFrom.Text = "From";

            // dtFrom
            dtFrom.Location = new Point(80, 68);
            dtFrom.Size = new Size(140, 25);

            // chkTo
            chkTo.AutoSize = true;
            chkTo.Location = new Point(240, 70);
            chkTo.Text = "To";

            // dtTo
            dtTo.Location = new Point(280, 68);
            dtTo.Size = new Size(140, 25);

            // btnSearch
            btnSearch.BackColor = Color.SeaGreen;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(600, 60);
            btnSearch.Size = new Size(100, 30);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            // lstResults
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(40, 220);
            lstResults.Size = new Size(720, 230);
            lstResults.DoubleClick += lstResults_DoubleClick;

            // lblRecom
            lblRecom.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblRecom.ForeColor = Color.DimGray;
            lblRecom.BackColor = Color.WhiteSmoke;
            lblRecom.Location = new Point(40, 460); 
            lblRecom.Size = new Size(700, 65);       
            lblRecom.AutoSize = false;
            lblRecom.TextAlign = ContentAlignment.TopLeft;
            lblRecom.Text = "";
            lblRecom.BringToFront();

            // lblHint
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblHint.ForeColor = Color.Gray;
            lblHint.Location = new Point(40, 535);   
            lblHint.Text = "Double click an event to view more info";

            // btnBack
            btnBack.BackColor = Color.DimGray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(620, 525);
            btnBack.Size = new Size(150, 40);
            btnBack.Text = "Back to Main Menu";
            btnBack.Click += btnBack_Click;

            // LocalEventsForm
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 640);
            Controls.Add(hdrPanel);
            Controls.Add(grpEventFilters);
            Controls.Add(lstResults);
            Controls.Add(lblRecom);
            Controls.Add(lblHint);
            Controls.Add(btnBack);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Local Events & Announcements";
            Load += LocalEventsForm_Load;

            hdrPanel.ResumeLayout(false);
            grpEventFilters.ResumeLayout(false);
            grpEventFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/