using System;

namespace PROG7312_POE_ST10300512
{
    public class ServiceStatus
    {   //getters and setters
        public string UniqueID { get; private set; }
        public string ResidentName { get; set; }
        public string IssueDescription { get; set; }
        public DateTime DateReported { get; private set; }
        public string CurrentStatus { get; set; }
        public int Priority { get; set; } // Lower the number the higher the priority

        // constructor
        public ServiceStatus(Issue issue)
        {
            UniqueID = issue.IssueId.ToString();
            ResidentName = $"Resident at {issue.Location}";
            IssueDescription = $"({issue.Category}) {issue.Description}";
            DateReported = issue.SubmittedDate;
            CurrentStatus = "Submitted";
            Priority = issue.Priority;
        }

        public override string ToString()
        {
            return $"ID: {UniqueID} ({IssueDescription})";
        }
    }
}