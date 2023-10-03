# Iowa County Adjacency API

## Assumptions

1. IDE is Visual Studio 2022.
2. Port 7182 is open on your machine.
3. County Codes used are FIPS ([List of counties in Iowa](https://en.wikipedia.org/wiki/List_of_counties_in_Iowa)).
4. Application only produces accurate results for Story, Greene, or Tama county adjacency.
5. You're on a Windows machine.

## Environment Setup and Starting the API

1. **Download and Install SQL Server LocalDB**
   - Installing SQL Server Express also works for this step ([SQL Server Downloads](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)).

2. **Start SQL Server LocalDB (using Powershell)**
   ```powershell
   sqllocaldb start "MSSQLLocalDB"
   ```

3. **Run Script to Create Tables and Entries**
   - Must be run in the root directory of the project
   ```powershell
   sqlcmd -S '(localdb)\MSSQLLocalDB' -i "initdb.sql"
   ```

4. **Install Dependencies, Build Project**
   - Must be run in the root directory of the project
   - `nuget restore`
   - Click on Build dropdown in Visual Sudio and select Build Solution

5. **Start the API**
   - You can press the start button in the VS GUI or use Ctrl+F5 to start the API.
   - Automatically opens a browser window containing Swagger UI for testing the application

## Using the API

1. Expand `/api/checkAdjacency` in the SwaggerUI.
2. Click on the 'Try it out' button and input Parameters for the county codes you'd like to check the adjacency for.
3. Leave Media type as is and click 'Execute'. The output should show up under responses in 'Response body'.

## Database Cleanup and Stopping the Application

1. **Stop SQL Server LocalDB (using Powershell)**
   ```powershell
   sqllocaldb stop "MSSQLLocalDB"
   ```

2. **Delete SQL Server LocalDB**
   ```powershell
   sqllocaldb delete "MSSQLLocalDB"
   ```

3. **Stop the Application**
   - Application can be stopped within the VS Code GUI.

## Addressing Limited Details Within Swagger Doc

Typically there would be more information in the Swagger doc to describe what the function does, what the county codes are, and possible responses from the API. There were some issues with getting the UI to generate a document including that information. If you are interested, there are comments documenting details of the function more in depth in `MainController.cs` within the Controllers directory.
