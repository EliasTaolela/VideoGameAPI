# VideoGameAPI

VideoGameAPI is a RESTful API developed in C# that provides information about various video games. It allows users to retrieve data such as game titles, genres, platforms, and more. This API is designed to be scalable and easy to integrate into other applications.

Features
Retrieve a list of video games with details.

Filter games by genre, platform, or release date.

Add, update, or delete game entries (CRUD operations).

Pagination support for large datasets.

JSON responses for easy consumption.

Technologies Used
C#: Primary programming language.

ASP.NET Core: Framework for building the API.

Entity Framework Core: ORM for database interactions.

SQL Server: Database for storing game information.

Getting Started
Prerequisites
.NET 6 SDK

SQL Server

Installation
Clone the repository:

#bash
Copy
Edit
git clone https://github.com/EliasTaolela/VideoGameAPI.git
cd VideoGameAPI
Configure the database:

Update the appsettings.json file with your SQL Server connection string.

Apply migrations and update the database:

bash
Copy
Edit
dotnet ef migrations add InitialCreate
dotnet ef database update
Run the application:

bash
Copy
Edit
dotnet run
The API will be available at (https://localhost:7291/scalar/v1)

Usage
Retrieve all games
Request:

http
Copy
Edit
GET /api/games
Response:

json
Copy
Edit
[
  {
    "id": 1,
    "title": "The Legend of Zelda: Breath of the Wild",
    "genre": "Action-adventure",
    "platform": "Nintendo Switch",
    "releaseDate": "2017-03-03"
  },
  {
    "id": 2,
    "title": "God of War",
    "genre": "Action",
    "platform": "PlayStation 4",
    "releaseDate": "2018-04-20"
  }
]
Retrieve a game by ID
Request:

http
Copy
Edit
GET /api/games/1
Response:

json
Copy
Edit
{
  "id": 1,
  "title": "The Legend of Zelda: Breath of the Wild",
  "genre": "Action-adventure",
  "platform": "Nintendo Switch",
  "releaseDate": "2017-03-03"
}
Contributing
Contributions are welcome! Please follow these steps:

Fork the repository.

Create a new branch:

bash
Copy
Edit
git checkout -b feature/your-feature-name
Make your changes and commit them:

bash
Copy
Edit
git commit -m "Add your message here"
Push to the branch:

bash
Copy
Edit
git push origin feature/your-feature-name
Open a pull request.

License
This project is licensed under the MIT License.

Contact
For any inquiries or feedback, please contact Elias Taolela.
