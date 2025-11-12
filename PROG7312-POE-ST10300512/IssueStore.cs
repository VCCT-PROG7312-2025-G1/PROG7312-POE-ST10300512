using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PROG7312_POE_ST10300512
{
    static class IssueStore
    {
        public static List<Issue> Issues { get; private set; } = new List<Issue>();

        // File path where issues are saved as JSON
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "issues.json");

        // Static constructor runs once when the class is first used
        static IssueStore()
        {
            Load();
        }
        public static void Add(Issue issue)
        {
            Issues.Add(issue);
            Save();
        }

        // Save current issues list to the JSON file
        public static void Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(Issues, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Error Handling
                MessageBox.Show("Failed to save issues: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load issues from disk
        public static void Load()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    Issues = JsonSerializer.Deserialize<List<Issue>>(json) ?? new List<Issue>();
                }
            }
            catch
            {
                // If loading fails start with an empty list
                Issues = new List<Issue>();
            }

            bool dataWasFixed = false;

            // Fix  issues that have a Priority of 0 by assigning defaults by Category
            foreach (var issue in Issues)
            {
                if (issue.Priority == 0)
                {
                    dataWasFixed = true;
                    switch (issue.Category)
                    {
                        case "Utilities":
                        case "Public Safety":
                            issue.Priority = 1; // Urgent
                            break;
                        case "Sanitation":
                        case "Roads":
                            issue.Priority = 2; // Medium
                            break;
                        default:
                            issue.Priority = 3; // Low
                            break;
                    }
                }
            }

            // Ensure at least requiredCount issues; seed sample data if not
            int requiredCount = 15;
            if (Issues.Count < requiredCount)
            {
                SeedMissingData(requiredCount);
                dataWasFixed = true;
            }

            // If data is changed or added data save it back to disk
            if (dataWasFixed)
            {
                Save();
            }
        }

        // Add seed sample issues until we reach requiredCount
        private static void SeedMissingData(int requiredCount)
        {
            var seedEntries = new List<(string Location, string Category, string Description, int Priority)>
            {
                ("123 Main St, Sandton", "Roads", "Large pothole at intersection", 2),
                ("Green Park, Durban", "Utilities", "Water pipe burst, flooding park", 1),
                ("Cnr Loop & Strand, Cape Town", "Public Safety", "Street light out for 3 days", 2),
                ("Market Square, Pretoria", "Sanitation", "Overflowing public bins, waste not collected", 1),
                ("Nelson Mandela Drive, Bloemfontein", "Roads", "Faded and illegible road markings", 3),
                ("Summerstrand Beach, Gqeberha", "Sanitation", "Litter and debris on beach front", 2),
                ("V&A Waterfront, Cape Town", "Utilities", "Power outage affecting multiple shops", 1),
                ("Melville, Johannesburg", "Roads", "Broken pavement, tripping hazard", 2),
                ("Florida Road, Durban", "Public Safety", "Traffic light stuck on red", 1),
                ("Church St, Pretoria", "Utilities", "Leaking fire hydrant", 1),
                ("City Hall, Johannesburg", "Sanitation", "Illegal dumping site forming", 1),
                ("Sea Point Promenade, Cape Town", "Public Safety", "Broken public bench, sharp edges", 3),
                ("OR Tambo Airport Rd, Kempton Park", "Roads", "Damaged guard rail on highway", 2),
                ("Moses Mabhida Stadium, Durban", "Sanitation", "Blocked storm drain near entrance", 2),
                ("Union Buildings, Pretoria", "Utilities", "Public water fountain is broken", 3)
            };

            // Add each seed entry if its not already present
            foreach (var entry in seedEntries)
            {
                if (Issues.Count >= requiredCount)
                {
                    break;
                }

                // Avoid duplicates by matching description and location
                if (!Issues.Any(issue => issue.Description == entry.Description && issue.Location == entry.Location))
                {
                    Issues.Add(new Issue
                    {
                        IssueId = Guid.NewGuid(),
                        Location = entry.Location,
                        Category = entry.Category,
                        Description = entry.Description,
                        SubmittedDate = DateTime.Now.AddDays(-Issues.Count)
                    });
                }
            }
        }
    }
}



/*----------------|||||||||||||||-------------------END OF FILE----------------|||||||||||||||-------------------*/