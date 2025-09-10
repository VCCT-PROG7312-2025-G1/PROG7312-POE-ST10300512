using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_ST10300512
{
    public class Issue
    {
        //Getters and Setters for Variables
        public Guid IssueId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();
        public DateTime SubmittedDate { get; set; }
    }
}
