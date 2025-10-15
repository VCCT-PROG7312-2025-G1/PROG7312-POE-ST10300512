using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_ST10300512
{
    public class Event
    {
        //Getters and setters for variables
        public Guid eventId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        // shows the user the listed events
        public override string ToString()
            => $"{Title} ({Category}) on {Date:dd MMMM yyyy} at {Location}";
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/