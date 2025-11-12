using System.Windows.Forms;
using System.Drawing;

namespace PROG7312_POE_ST10300512
{
    partial class ServiceStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchPrompt;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblResidentName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUpdatePrompt;
        private System.Windows.Forms.ComboBox cmbUpdateStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFilterPriority;
        private System.Windows.Forms.ComboBox cmbFilterPriority;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetFilters;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblHeaderTitle = new Label();
            grpSearch = new GroupBox();
            lblSearchPrompt = new Label();
            txtSearchID = new TextBox();
            btnSearch = new Button();
            dgvRequests = new DataGridView();
            grpDetails = new GroupBox();
            lblRequestID = new Label();
            lblResidentName = new Label();
            lblDescription = new Label();
            lblReportDate = new Label();
            lblStatus = new Label();
            lblUpdatePrompt = new Label();
            cmbUpdateStatus = new ComboBox();
            btnUpdateStatus = new Button();
            btnBack = new Button();
            lblFilterPriority = new Label();
            cmbFilterPriority = new ComboBox();
            lblFilterStatus = new Label();
            cmbFilterStatus = new ComboBox();
            btnFilter = new Button();
            btnResetFilters = new Button();

            headerPanel.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvRequests)).BeginInit();
            grpDetails.SuspendLayout();
            SuspendLayout();

            // headerPanel
            headerPanel.BackColor = Color.FromArgb(0, 122, 77);
            headerPanel.Controls.Add(lblHeaderTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(984, 70);
            headerPanel.TabIndex = 0;

            // lblHeaderTitle
            lblHeaderTitle.Dock = DockStyle.Fill;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Text = "Service Request Status";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;

            // grpSearch
            grpSearch.Controls.Add(lblSearchPrompt);
            grpSearch.Controls.Add(txtSearchID);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(lblFilterPriority);
            grpSearch.Controls.Add(cmbFilterPriority);
            grpSearch.Controls.Add(lblFilterStatus);
            grpSearch.Controls.Add(cmbFilterStatus);
            grpSearch.Controls.Add(btnFilter);
            grpSearch.Controls.Add(btnResetFilters);
            grpSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSearch.Location = new Point(20, 90);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(470, 270);
            grpSearch.TabIndex = 1;
            grpSearch.TabStop = false;
            grpSearch.Text = "Track & Filter Requests"; 

            // lblSearchPrompt
            lblSearchPrompt.AutoSize = true;
            lblSearchPrompt.Font = new Font("Segoe UI", 9F);
            lblSearchPrompt.Location = new Point(20, 42);
            lblSearchPrompt.Name = "lblSearchPrompt";
            lblSearchPrompt.Size = new Size(80, 15);
            lblSearchPrompt.TabIndex = 0;
            lblSearchPrompt.Text = "Search by ID:";

            // txtSearchID
            txtSearchID.Font = new Font("Segoe UI", 9F);
            txtSearchID.Location = new Point(106, 39);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(238, 23);
            txtSearchID.TabIndex = 1;

            // btnSearch
            btnSearch.BackColor = Color.FromArgb(255, 182, 18);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(350, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += new System.EventHandler(btnSearch_Click);

            // lblFilterPriority
            lblFilterPriority.AutoSize = true;
            lblFilterPriority.Font = new Font("Segoe UI", 9F);
            lblFilterPriority.Location = new Point(20, 100);
            lblFilterPriority.Name = "lblFilterPriority";
            lblFilterPriority.Size = new Size(92, 15);
            lblFilterPriority.TabIndex = 7;
            lblFilterPriority.Text = "Filter by Priority:";

            // cmbFilterPriority
            cmbFilterPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterPriority.Font = new Font("Segoe UI", 9F);
            cmbFilterPriority.FormattingEnabled = true;
            cmbFilterPriority.Location = new Point(23, 125);
            cmbFilterPriority.Name = "cmbFilterPriority";
            cmbFilterPriority.Size = new Size(427, 23);
            cmbFilterPriority.TabIndex = 3;

            // lblFilterStatus
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9F);
            lblFilterStatus.Location = new Point(20, 160);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(86, 15);
            lblFilterStatus.TabIndex = 8;
            lblFilterStatus.Text = "Filter by Status:";

            // cmbFilterStatus
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 9F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(23, 185);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(427, 23);
            cmbFilterStatus.TabIndex = 4;

            // btnFilter
            btnFilter.BackColor = Color.FromArgb(0, 94, 184);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(330, 220);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 30);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += new System.EventHandler(btnFilter_Click);

            // btnResetFilters
            btnResetFilters.BackColor = Color.Gray;
            btnResetFilters.FlatAppearance.BorderSize = 0;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(200, 220);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(120, 30);
            btnResetFilters.TabIndex = 6;
            btnResetFilters.Text = "Reset";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += new System.EventHandler(btnResetFilters_Click);

            // dgvRequests
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(20, 380);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowTemplate.Height = 25;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(944, 145);
            dgvRequests.TabIndex = 2;
            dgvRequests.SelectionChanged += new System.EventHandler(dgvRequests_SelectionChanged);

            // grpDetails
            grpDetails.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            grpDetails.Controls.Add(lblRequestID);
            grpDetails.Controls.Add(lblResidentName);
            grpDetails.Controls.Add(lblDescription);
            grpDetails.Controls.Add(lblReportDate);
            grpDetails.Controls.Add(lblStatus);
            grpDetails.Controls.Add(lblUpdatePrompt);
            grpDetails.Controls.Add(cmbUpdateStatus);
            grpDetails.Controls.Add(btnUpdateStatus);
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.Location = new Point(505, 90);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(459, 270);
            grpDetails.TabIndex = 3;
            grpDetails.TabStop = false;
            grpDetails.Text = "Request Details";

            // lblRequestID
            lblRequestID.AutoSize = true;
            lblRequestID.Font = new Font("Segoe UI", 9F);
            lblRequestID.Location = new Point(20, 30);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(115, 15);
            lblRequestID.Text = "ID: (Select a request)";

            // lblResidentName
            lblResidentName.AutoSize = true;
            lblResidentName.Font = new Font("Segoe UI", 9F);
            lblResidentName.Location = new Point(20, 55);
            lblResidentName.Name = "lblResidentName";
            lblResidentName.Size = new Size(61, 15);
            lblResidentName.Text = "Resident: ";

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.Location = new Point(20, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 15);
            lblDescription.Text = "Details: ";

            // lblReportDate
            lblReportDate.AutoSize = true;
            lblReportDate.Font = new Font("Segoe UI", 9F);
            lblReportDate.Location = new Point(20, 105);
            lblReportDate.Name = "lblReportDate";
            lblReportDate.Size = new Size(61, 15);
            lblReportDate.Text = "Reported: ";

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.Location = new Point(20, 130);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.Text = "Status: ";

            // lblUpdatePrompt
            lblUpdatePrompt.AutoSize = true;
            lblUpdatePrompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpdatePrompt.Location = new Point(20, 170);
            lblUpdatePrompt.Name = "lblUpdatePrompt";
            lblUpdatePrompt.Size = new Size(88, 15);
            lblUpdatePrompt.Text = "Update Status:";

            // cmbUpdateStatus
            cmbUpdateStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateStatus.Font = new Font("Segoe UI", 9F);
            cmbUpdateStatus.FormattingEnabled = true;
            cmbUpdateStatus.Location = new Point(20, 195);
            cmbUpdateStatus.Name = "cmbUpdateStatus";
            cmbUpdateStatus.Size = new Size(419, 23);
            cmbUpdateStatus.TabIndex = 3;

            // btnUpdateStatus
            btnUpdateStatus.BackColor = Color.FromArgb(222, 41, 18);
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(319, 225);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(120, 30);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += new System.EventHandler(btnUpdateStatus_Click);

            // btnBack
            btnBack.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            btnBack.BackColor = Color.DimGray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += (s, e) => Close();

            // ServiceStatusForm
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 600);
            Controls.Add(btnBack);
            Controls.Add(grpDetails);
            Controls.Add(dgvRequests);
            Controls.Add(grpSearch);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 639);
            Name = "ServiceStatusForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Service Request Status";
            Load += new System.EventHandler(ServiceStatusForm_Load);

            headerPanel.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvRequests)).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/