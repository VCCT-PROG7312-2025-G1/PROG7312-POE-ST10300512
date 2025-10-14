namespace PROG7312_POE_ST10300512
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent(); 
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.ShowDialog();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm eventsForm = new LocalEventsForm();
            eventsForm.ShowDialog();
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            // WIP - For Part 2
        }
    }
}
