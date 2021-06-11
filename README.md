Below is the project Structure

PlayerAPI.API -API Project 
PlayerAPI.Models - Models and Data type objects project -Entities mapped using Entity Framework 
PlayerAPI.Services -Business Logic Uses PlayerAPI.Models internally to extract data
PlayerAPI.Test -Nunit test project contains unit test methods to test PlayerService and PlyerSelectionController
__________________________________________________________________________________________________________________________________

To Run the Project 
1.Open PlayerDB.sql attched under solution file in sql server and execute it -this will create Database and related tables

2 Open solution in visual studio 

3. Open app.settings file from PlayerAPI.API project change ConnectionStrings section add your connection string

4. Open PlayerDBContext.cs from PlayerAPI.Models project which is under Models folder

change OnConfiguring section to update entities if in case it is required 

5. Set PlayerAPI.API as startup project and run it in the browser 

________________________________________________________________________________________________________
To run the API from any tool like Postman or Fiddler 

Select method type as Post .Following APIs are avilable .getPlayerList will return the list 

Url -http://localhost:52637/playerselection/getPlayerList
Body-{"PlayerHeight":5.4,"PlayerBmi":24,"PlayerRuns":7000,"PlayerWickets":100,"PlayerStumpings":100}

url- http://localhost:52637/playerselection/getBatsmanList
Body-{"PlayerHeight":5.4,"PlayerBmi":24,"PlayerRuns":7000,"PlayerWickets":100,"PlayerStumpings":100}

url -http://localhost:52637/playerselection/getBowlerList
Body-{"PlayerHeight":5.4,"PlayerBmi":24,"PlayerRuns":7000,"PlayerWickets":100,"PlayerStumpings":100}

url -http://localhost:52637/playerselection/getwicketkeeperList
Body-{"PlayerHeight":5.4,"PlayerBmi":24,"PlayerRuns":7000,"PlayerWickets":100,"PlayerStumpings":100}





