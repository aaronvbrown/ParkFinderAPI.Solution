
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
* Navigate to this project's production directory "ParkFinderAPI"
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

## API Documentation
* A swagger web page is configured to open showing api endpoints here:  **https://localhost:5000/swagger/index.html**
* Interact with the API using Postman via **https://localhost:5000**

### Endpoints
The base URL is: ***https://localhost:5000***

#### Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Available Components
Parks

#### Example Queries

```http://localhost:5000/api/Parks``` (GET, POST)
```http://localhost:5000/api/Parks/1``` (GET, PUT, DELETE)

##### Sample GET Index Response for ```http://localhost:5000/api/Parks```:  
```
[
  {
      "parkId": 1,
      "name": "Yellowstone",
      "state": "Montana",
      "type": "National Park"
  },
  {
      "parkId": 2,
      "name": "Crater Lake",
      "state": "Oregon",
      "type": "National Park"
  }
]
```

##### Sample POST Request ```http://localhost:5000/api/Parks``` 


Request Body:
```
{
    "name": "Mt St Helens",
    "state": "Washington",
    "type": "National Monument"
}
```
Response Body:
```
{
    "parkId": 6,
    "name": "Mt St Helens",
    "state": "Washington",
    "type": "National Monument"
}
```

##### Sample GET Response for ```http://localhost:5000/api/Parks/1```:  
```
  {
      "parkId": 1,
      "name": "Yellowstone",
      "state": "Montana",
      "type": "National Park"
  }
```

##### Sample PUT Request ```http://localhost:5000/api/Parks/1``` 

Request Body:
```
{
    "parkId":1,
    "name":"Yellowrock",
    "state":"Montana",
    "type":"National Park"
}
```

The API should return a  Status 204 No Content response.  Verify update results with a GET request.



## Known Bugs
* Pagination via the "pagination" branch is currently generating a 415 error response.
* Please report any bugs at the [github repo issues page](https://github.com/aaronvbrown/ParkFinderAPI.Solution/issues)

## Further Exploration
* [Pagination](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/sort-filter-page?view=aspnetcore-6.0)
* [Token-Based Authentication](https://www.yogihosting.com/jwt-api-aspnet-core/)
* [API Versioning](https://learn.microsoft.com/en-us/shows/visual-studio-toolbox/versioning-aspnet-core-services)
* [CORS](https://learn.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0)
* General [Guide to Further Exploration with APIs](https://part-time-evening.learnhowtoprogram.com/c-and-net/building-an-api/further-exploration-with-apis) 

## Attributions
  


## License
MIT License



Copyright (c) 2023 Aaron Brown