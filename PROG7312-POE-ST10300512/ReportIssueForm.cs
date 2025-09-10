using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE_ST10300512
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent(); 
        }

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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
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
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a brief description.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var issue = new Issue
            {
                IssueId = Guid.NewGuid(),
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                SubmittedDate = DateTime.Now
            };

            foreach (var item in lstAttachments.Items)
            {
                issue.Attachments.Add(item.ToString());
            }

            IssueStore.Add(issue);

            MessageBox.Show("Report submitted successfully.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
            UpdateEngagement();
        }

        private void UpdateEngagement()
        {
            int score = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text)) score += 35;
            if (cmbCategory.SelectedIndex >= 0) score += 30;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text)) score += 30;
            if (lstAttachments.Items.Count > 0) score += 5;

            if (score > 100) score = 100;
            progressBar.Value = score;

            if (score < 40)
                lblEngagement.Text = "Not all details Entered - Please add more";
            else if (score < 70)
                lblEngagement.Text = "Almost complete";
            else if (score < 100)
                lblEngagement.Text = "Perfect - Add a File to support your report if needed";
            else
                lblEngagement.Text = "Perfect - A fully detailed report";
        }
    }

}
