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
    public partial class LocalEventsForm : Form
    {
        // tracks user searches
        private Dictionary<string, int> searchHistory = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        public LocalEventsForm()
        {
            InitializeComponent();

            // setup dropdown and list when form loads
            PopulateCategoryList();
            DisplayEvents(EventStore.GetAllEvents());
        }

        // fill category dropdown from data
        private void PopulateCategoryList()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            foreach (var category in EventStore.GetUniqueCategories().OrderBy(j => j))
                cmbCategory.Items.Add(category);
            cmbCategory.SelectedIndex = 0;
        }

        // show events in the list
        private void DisplayEvents(IEnumerable<Event> eventList)
        {
            lstResults.Items.Clear();
            foreach (var ev in eventList)
                lstResults.Items.Add(ev);
        }

        // filter events by category and input when search button is clicked, and show recommendations

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim().ToLower();
            var selectedCategory = cmbCategory.Text;

            IEnumerable<Event> results;

            // filters by category
            if (selectedCategory == "All")
                results = EventStore.GetAllEvents();
            else
                results = EventStore.GetEventsByCategory(selectedCategory);

            // filters by text input
            if (!string.IsNullOrEmpty(searchText))
            {
                results = results.Where(ev =>
                    ev.Title.ToLower().Contains(searchText) ||
                    ev.Description.ToLower().Contains(searchText) ||
                    ev.Location.ToLower().Contains(searchText));
            }

            DisplayEvents(results);

            // track searches for recommendations
            if (selectedCategory != "All" && !string.IsNullOrWhiteSpace(selectedCategory))
            {
                if (!searchHistory.ContainsKey(selectedCategory))
                    searchHistory[selectedCategory] = 0;
                searchHistory[selectedCategory]++;
            }

            ShowRecommendations();
        }

        private void ShowRecommendations()
        {
            if (searchHistory.Count == 0) return;

            // get most used category
            var topCategory = searchHistory.OrderByDescending(c => c.Value).First().Key;

            // find events in that category
            var recommended = EventStore.GetEventsByCategory(topCategory)
                                        .Take(2)
                                        .ToList();

            // displays recommendations based on category searched
            string recommendationText = $"Based on your interest in '{topCategory}', you might also like:\n\n";
            foreach (var ev in recommended)
                recommendationText += $"- {ev.Title} on {ev.Date:d} at {ev.Location}\n";

            lblRecom.Text = recommendationText;
        }


        // close page
        private void btnBack_Click(object sender, EventArgs i)
        {
            Close();
        }

        // OPen a popup with event details when an event is double clicked
        private void lstResults_DoubleClick(object sender, EventArgs i)
        {
            if (lstResults.SelectedItem == null) return;

            var evnt = (Event)lstResults.SelectedItem;
            MessageBox.Show($"{evnt.Title}\n{evnt.Description}\n\nDate: {evnt.Date:d}\nLocation: {evnt.Location}",
                "Event Info");

        }

        private void LocalEventsForm_Load(object sender, EventArgs i)
        {
        }
    }
}

/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/
