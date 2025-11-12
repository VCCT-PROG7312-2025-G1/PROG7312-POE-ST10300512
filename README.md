<h2>PROG7312-POE-ST10300512</h2> <h5>Description</h5> This project is a C# Windows Forms application developed for the PROG7312 module. It functions as a comprehensive portal for municipal services, allowing residents to interact with their local municipality in three key ways:


Report Issues: Submit detailed reports for service problems like potholes, water leaks, or power outages.

View Local Events: Browse a list of upcoming community events and announcements.

Track Service Status: Check the real-time status of submitted reports using a unique ID and filter by category.


<h5>Requirements</h5> To compile and run this application, you will need:

Visual Studio 2022 (or a similar C# IDE)

.NET 8.0 SDK (as per the project)

<h5>Installing and setting up</h5> 
<h6>Option 1: Download from Zip (Recommended)</h6>

Extract: Unzip the  .zip file to a folder on your computer.

Open Solution: Navigate into the extracted folder and double-click the PROG7312-POE-ST10300512.sln file. This will open the project in Visual Studio.

Compile: In the Visual Studio menu, select Build > Build Solution (or press Ctrl+Shift+B). This will restore all necessary packages and compile the code.

Run: Press the Start button or press F5 to run the application.

<h6>Option 2: GitHub</h6>

Clone: Open your terminal or Git client and clone the repository.

Open, Compile, and Run: Follow steps 2-4 from Option 1 above.

<h5>How to Use the Application</h5> 

Once the application is running, you will be greeted with the Main Menu.

<h6>1. Report an Issue</h6>

Click the "New Report" button.

Fill in all the required fields: Location, Category, Priority (1 for high, 3 for low), and a Description.

(Optional) Click "Attach Images/Documents" to add supporting files.

Click "Submit". Your report will be saved and assigned a unique ID.


<h6>2. Local Events</h6>

Click the "View Events" button.

You can browse the full list of events.

Use the search bar and category dropdown to filter the list and find specific events.


<h6>3. Service Status</h6>

Click the "Check Status" button.

You will see a grid of all submitted service reports.

To find your report: Enter a part of your unique ID into the "Search by ID" box and click "Search".

To filter the list: Use the "Filter by Priority" or "Filter by Status" dropdowns and click the "Filter" button. Click "Reset" to clear the filters.

To update a report (for demo purposes):Select a report from the grid.

The details will appear in the "Request Details" panel.

Choose a new, valid status from the update dropdown.

Click "Update".

<h5>Data Storage</h5> 

<h6>Side Notes:</h6> 

This application uses a local JSON file for data persistence. This means all your reported issues are saved on your computer.

File Name: issues.json

Default Location: The file is created automatically in the application's debug directory. The path will be similar to: ...\PROG7312-POE-ST10300512\bin\Debug\net8.0-windows\issues.json

Seeded Data: On the first run, if the issues.json file is empty or has fewer than 15 reports, the application will automatically populate it with 15 sample entries for testing.

Data Migration: The application also automatically updates this file to fix any old data (e.g., reports saved with a priority of 0).


GitHub link: https://github.com/VCCT-PROG7312-2025-G1/PROG7312-POE-ST10300512

Youtube link: https://youtu.be/AJ7OpPOlUxI
