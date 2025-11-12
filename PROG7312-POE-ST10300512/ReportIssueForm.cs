using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace PROG7312_POE_ST10300512
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent();

            // Update engagement progress whenever inputs change
            txtLocation.TextChanged += (s, e) => UpdateEngagement();
            cmbCategory.SelectedIndexChanged += (s, e) => UpdateEngagement();
            rtbDescription.TextChanged += (s, e) => UpdateEngagement();
            cmbPriority.SelectedIndexChanged += (s, e) => UpdateEngagement();
        }

        // Opens a file dialog to attach images or documents
        private void BtnAttach_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Images and documents|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.pdf;*.doc;*.docx|All files|*.*"
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var f in ofd.FileNames)
                {
                    if (!lstAttachments.Items.Contains(f))
                        lstAttachments.Items.Add(f);
                }
                UpdateEngagement();
            }
        }

        // Submits a new issue report
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check that all required fields are filled
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the Report.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPriority.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a priority level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a brief description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected priority value
            int selectedPriority = int.Parse(cmbPriority.SelectedItem.ToString().Split(' ')[0]);

            // Create a new issue object
            var issue = new Issue
            {
                IssueId = Guid.NewGuid(),
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                SubmittedDate = DateTime.Now,
                Priority = selectedPriority
            };

            // Add any attached files to the issue
            foreach (var item in lstAttachments.Items)
            {
                issue.Attachments.Add(item.ToString());
            }

            // Save the issue and update the service list
            IssueStore.Add(issue);
            ServiceStore.Instance.AddRequest(new ServiceStatus(issue));

            MessageBox.Show("Report submitted successfully.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear all fields after submission
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
            UpdateEngagement();
        }

        // Updates the engagement progress bar and message
        private void UpdateEngagement()
        {
            int score = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) score += 25;
            if (cmbCategory.SelectedIndex >= 0) score += 20;
            if (cmbPriority.SelectedIndex >= 0) score += 20;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) score += 30;
            if (lstAttachments.Items.Count > 0) score += 5;

            if (score > 100) score = 100;
            progressBar.Value = score;

            if (score == 0)
                lblEngagement.Text = "Your voice matters – complete your report!";
            else if (score < 40)
                lblEngagement.Text = "Not all details Entered - Please add more";
            else if (score < 70)
                lblEngagement.Text = "Almost complete";
            else if (score < 100)
                lblEngagement.Text = "Great detail!";
            else
                lblEngagement.Text = "Perfect - A fully detailed report";
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/
