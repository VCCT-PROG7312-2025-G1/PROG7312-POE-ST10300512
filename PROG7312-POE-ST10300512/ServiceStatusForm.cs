using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312_POE_ST10300512
{
    public partial class ServiceStatusForm : Form
    {
        private ServiceStore store = ServiceStore.Instance;
        private ServiceStatus _selectedRequest;

        public ServiceStatusForm()
        {
            InitializeComponent();
        }

        // When the form loads set filters and load data
        private void ServiceStatusForm_Load(object sender, EventArgs e)
        {
            PopulateFilters();
            ApplyFiltersAndRefreshGrid();
            grpDetails.Enabled = false; 
        }

        // Fill the filter dropdowns for Priority and Status
        private void PopulateFilters()
        {
            // Priority filter options
            cmbFilterPriority.Items.Clear();
            cmbFilterPriority.Items.Add("All Priorities");
            cmbFilterPriority.Items.Add("1 - High (Urgent)");
            cmbFilterPriority.Items.Add("2 - Medium (Normal)");
            cmbFilterPriority.Items.Add("3 - Low (Minor)");
            cmbFilterPriority.SelectedIndex = 0;

            // Status filter options
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("All Statuses");

            // Get all unique statuses from stored requests
            var allStatuses = store.GetAllRequests()
                                   .Select(r => r.CurrentStatus)
                                   .Distinct()
                                   .OrderBy(s => s);
            foreach (var status in allStatuses)
            {
                cmbFilterStatus.Items.Add(status);
            }
            cmbFilterStatus.SelectedIndex = 0;
        }

        // Filter and refresh the list of requests shown in the grid
        private void ApplyFiltersAndRefreshGrid()
        {
            IEnumerable<ServiceStatus> filteredRequests = store.GetAllRequests();

            if (cmbFilterPriority.SelectedIndex > 0)
            {
                int selectedPriority = int.Parse(cmbFilterPriority.SelectedItem.ToString().Split(' ')[0]);
                filteredRequests = filteredRequests.Where(r => r.Priority == selectedPriority);
            }

            if (cmbFilterStatus.SelectedIndex > 0)
            {
                string selectedStatus = cmbFilterStatus.SelectedItem.ToString();
                filteredRequests = filteredRequests.Where(r => r.CurrentStatus == selectedStatus);
            }

            dgvRequests.DataSource = null;
            dgvRequests.DataSource = filteredRequests.ToList();
        }

        // Apply filters when the Filter button is clicked
        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFiltersAndRefreshGrid();
        }

        // Reset all filters to default
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cmbFilterPriority.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;
            ApplyFiltersAndRefreshGrid();
        }

        // Search for a request by its ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idToFind = txtSearchID.Text.Trim();
            if (string.IsNullOrWhiteSpace(idToFind))
            {
                MessageBox.Show("Please enter a partial request ID to search for.");
                return;
            }

            var allRequests = store.GetAllRequests();

            ServiceStatus found = allRequests.FirstOrDefault(request =>
                request.UniqueID.IndexOf(idToFind, StringComparison.OrdinalIgnoreCase) >= 0);

            if (found != null)
            {
                foreach (DataGridViewRow row in dgvRequests.Rows)
                {
                    var request = (ServiceStatus)row.DataBoundItem;
                    if (request.UniqueID == found.UniqueID)
                    {
                        row.Selected = true;
                        dgvRequests.CurrentCell = row.Cells[0];
                        break;
                    }
                }
                PopulateDetails(found);
            }
            else
            {
                MessageBox.Show("Request ID not found.", "Search Result");
            }
        }

        // When a different row is selected in the grid show its details
        private void dgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                _selectedRequest = (ServiceStatus)dgvRequests.SelectedRows[0].DataBoundItem;
                PopulateDetails(_selectedRequest);
            }
            else
            {
                grpDetails.Enabled = false;
                _selectedRequest = null;
            }
        }

        // Show the details of a selected request
        private void PopulateDetails(ServiceStatus request)
        {
            _selectedRequest = request;

            lblRequestID.Text = $"ID: {request.UniqueID}";
            lblResidentName.Text = $"Resident: {request.ResidentName}";
            lblDescription.Text = $"Details: {request.IssueDescription}";
            lblReportDate.Text = $"Reported: {request.DateReported.ToShortDateString()}";
            lblStatus.Text = $"Status: {request.CurrentStatus}";

            cmbUpdateStatus.DataSource = null;
            List<string> nextSteps = store.GetPossibleNextSteps(request.CurrentStatus);
            cmbUpdateStatus.DataSource = nextSteps;

            grpDetails.Enabled = true;
            btnUpdateStatus.Enabled = (nextSteps.Count > 0);
        }

        // Update the status of a selected request
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedRequest == null) return;

            string newStatus = (string)cmbUpdateStatus.SelectedItem;
            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a new status.");
                return;
            }

            bool success = store.UpdateRequestStatus(_selectedRequest, newStatus);

            if (success)
            {
                MessageBox.Show("Status updated successfully!");
                ApplyFiltersAndRefreshGrid();
                PopulateDetails(_selectedRequest);
                PopulateFilters();
            }
            else
            {
                MessageBox.Show("An error occurred. Status was not updated.");
            }
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/
