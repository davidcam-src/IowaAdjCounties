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
