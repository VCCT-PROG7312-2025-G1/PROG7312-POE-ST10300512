using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7312_POE_ST10300512
{
    public static class EventStore
    {
        // queue keeps events in order
        private static Queue<Event> eventQueue = new Queue<Event>();


        // dictionary for category lookups
        private static Dictionary<string, List<Event>> categoryLookup = new Dictionary<string, List<Event>>(StringComparer.OrdinalIgnoreCase);

        // Set for keeping track of unique category names
        private static HashSet<string> uniqueCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        static EventStore()
        {
            Samples();
        }

        // adds events from the sample data
        public static void AddEvent(Event newEvent)
        {
            eventQueue.Enqueue(newEvent);

            if (!categoryLookup.ContainsKey(newEvent.Category))
                categoryLookup[newEvent.Category] = new List<Event>();

            categoryLookup[newEvent.Category].Add(newEvent);
            uniqueCategories.Add(newEvent.Category);
        }

        // returns everything in the queue
        public static IEnumerable<Event> GetAllEvents() => eventQueue.ToList();

        // gets events under a specific category
        public static IEnumerable<Event> GetEventsByCategory(string category)
        {
            return categoryLookup.ContainsKey(category)
                ? categoryLookup[category]
                : Enumerable.Empty<Event>();
        }

        // returns all categories
        public static IEnumerable<string> GetUniqueCategories() => uniqueCategories;

        // removes old events
        public static void RemovePastEvents()
        {
            var today = DateTime.Today;

            eventQueue = new Queue<Event>(eventQueue.Where(i => i.Date >= today));

        }

        // adds a few example events
        private static void Samples()
        {
            var sampleEvents = new List<Event>
            {
                new Event { Title="Water Maintenance", Category="Utilities", Location="Green Point", Date=DateTime.Now.AddDays(2), Description="Water line maintenance" },
                new Event { Title="Recycling Drive", Category="Environment", Location="Sea Point", Date=DateTime.Now.AddDays(5), Description="Community recycling drive" },
                new Event { Title="Road Closure Notice", Category="Roads", Location="Rondebosch", Date=DateTime.Now.AddDays(1), Description="Re-tarring of roads notice" },
                new Event { Title="Crime Awareness Warnings", Category="Public Safety", Location="Fish Hoek", Date=DateTime.Now.AddDays(3), Description="Crime awareness discussion" },
                new Event { Title="Water Testing", Category="Utilities", Location="Constantia", Date=DateTime.Now.AddDays(4), Description="Testing of water safety" },
                new Event { Title="Beach Clean up", Category="Environment", Location="Somerset West", Date=DateTime.Now.AddDays(10), Description="Community driven litter pick up" },
                new Event { Title="Road Disaster", Category="Roads", Location="Claremont", Date=DateTime.Now.AddDays(6), Description="Roads flooded" },
                new Event { Title="Neighborhood watch", Category="Public Safety", Location="Blouberg", Date=DateTime.Now.AddDays(-1), Description="Join the neighborhood watch" }
            };

            foreach (var newEvent in sampleEvents)
                AddEvent(newEvent);
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/