
# _ParkFinderAPI_

#### By **Aaron Brown**

#### An API with information about public recreation areas.

## Technologies Used

* [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC v6.0](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
* [Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0)
* [MySQL](https://www.mysql.com/downloads/)
* [Postman](https://www.postman.com/)
* [Visual Studio Code](https://code.visualstudio.com/download) + the C# Dev Kit Extension: ms-dotnettools.csdevkit

## Description
This API returns information about various recreation areas through an API.  


## Setup Requirements

* You'll need the .NET SDK installed on your system to run the app.  Downloads for the .NET SDK are available [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
* Install dotnet-ef globally to enable databse migrations using the following command
  ```bash
  $ dotnet tool install --global dotnet-ef --version 6.0.0
  ```
* For further database migration assistance, this [lesson](https://part-time-evening.learnhowtoprogram.com/c-and-net/many-to-many-relationships/code-first-development-and-migrations) from learnhowtoprogram.com is helpful.
* Clone the repository **git clone https://github.com/aaronvbrown/ParkFinderAPI.Solution.git**  in the terminal
* Navigate to this project's production directory "ParkFinderAI"
* Create a file appsettings.json, adding the following code.  (Replace uid and pwd with your own username and password for MySQL)
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=aaron_brown;uid=[your-username];pwd=[your-password];"
    }
  }
  ```
* Run **dotnet ef database update** from the command line to create a database locally that the project can use.
* Run **dotnet run** in the command line to start the app
* Run **dotnet watch run** in the command line to load in development mode with a watcher
* A swagger web page is configured to open showing api endpoints here:  **https://localhost:5001/swagger/index.html**
* Interact with the API using Postman via **https://Localhost:5001**

## Known Bugs
* Pagination via the "pagination" branch is currently generating a 415 error response.
* Please report any bugs at the [github repo issues page](https://github.com/aaronvbrown/ParkFinderAPI.Solution/issues)

## Further Exploration
* [Token-Based Authentication](https://www.yogihosting.com/jwt-api-aspnet-core/)
* [API Versioning](https://learn.microsoft.com/en-us/shows/visual-studio-toolbox/versioning-aspnet-core-services)
* [Pagination](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-6.0)
* [CORS](https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0)
* General [Guide to Further Exploration with APIs](https://part-time-evening.learnhowtoprogram.com/c-and-net/building-an-api/further-exploration-with-apis) 

## Attributions
  


## License
MIT License



Copyright (c) 2023 Aaron Brown