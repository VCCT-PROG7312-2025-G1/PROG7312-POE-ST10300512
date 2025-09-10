using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PROG7312_POE_ST10300512
{

    // This Class is made to store the inputed report as a json file to be accessed later
    static class IssueStore
    {
        public static List<Issue> Issues { get; private set; } = new List<Issue>();
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "issues.json");

        static IssueStore()
        {
            Load();
        }

        public static void Add(Issue issue)
        {
            Issues.Add(issue);
            Save();
        }

        public static void Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(Issues, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save issues: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                Issues = new List<Issue>();
            }
        }
    }
}
