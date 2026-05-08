# WelcomeApp

A simple ASP.NET Core MVC web application that connects to a MySQL database using Entity Framework Core and the Pomelo MySQL provider.

## Overview

- Framework: .NET 10.0
- Project: `WelcomeApp/WelcomeApp.csproj`
- Web app type: ASP.NET Core MVC
- Database provider: `Pomelo.EntityFrameworkCore.MySql`
- Database creation: `db.Database.EnsureCreated()` at startup

The application demonstrates:

- MVC architecture with controllers, views, and dependency injection
- MySQL database connectivity via EF Core
- Docker Compose support with a MySQL service

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
- [Docker](https://www.docker.com/get-started) (only if you want to run using Docker Compose)

## Run locally
1. Restore dependencies and run the app:

```powershell
dotnet restore
(dotnet build)
dotnet run
```

2. Open the browser at `https://localhost:5001` or the URL shown in the console.

## Configuration

The default MySQL connection string is defined in `WelcomeApp/appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=ecommerce_db;user=ecommerce_user;password=ecommerce_pass;"
}
```

If you use Docker Compose, the container overrides this with the MySQL service endpoint.

## Docker Compose

This project includes `docker-compose.yml` to run the app with a local MySQL container.

1. From the repository root, run:

```powershell
docker compose up --build
```

2. The application will be available at `http://localhost:5000`.
3. The MySQL service is exposed on host port `3306`.

### Docker Compose services

- `mysql` — MySQL 8.0 database
- `ecommerce-app` — ASP.NET Core app built from the repository

## Project structure

- `WelcomeApp/Program.cs` — app startup and service configuration
- `WelcomeApp/Controllers/HomeController.cs` — sample controller
- `WelcomeApp/Views/` — Razor views
- `WelcomeApp/Data/AppDbContext.cs` — EF Core database context

## Notes

- The application uses `EnsureCreated()` to create the database automatically if it does not exist.
- No EF Core migrations are included in this repository.
- The home page checks database connectivity and displays a status message via `ViewBag.DbStatus`.
