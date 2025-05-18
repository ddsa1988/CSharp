https://www.youtube.com/watch?v=AhAxLiGC7Pc

##### Create Database #####

install Microsoft.EntityFrameworkCore.Sqlite
install Microsoft.EntityFrameworkCore.Tools
install Microsoft.EntityFrameworkCore.Design

Create a connection string on "appsettings.json"
Call the connection string on "Program.cs"

Create a class inherited from DbContext class

Create an extension method from "WebApplication" to create the database when the app starts 
Call the extension method on "Program.cs"

dotnet ef migrations add InitialCreate --output-dir "Directory Name"
dotnet ef database update
