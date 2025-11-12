namespace PROG7312_POE_ST10300512
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent(); 
        }
        //Part 1
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm reportForm = new ReportIssueForm();
            reportForm.ShowDialog();
        }
        //Part 2
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm eventsForm = new LocalEventsForm();
            eventsForm.ShowDialog();
        }
        //Part 3
        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            ServiceStatusForm serviceForm = new ServiceStatusForm();
            serviceForm.ShowDialog();
        }
    }
}


/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/
