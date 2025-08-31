# 🏡 MagicVilla API

A **RESTful Web API** built with **ASP.NET Core** for managing villa listings in a resort/real estate platform. This project demonstrates clean architecture, JWT authentication, API versioning, and industry-standard practices for building scalable APIs.

---

## ✨ Features

- ✅ CRUD operations for Villas (Create, Read, Update, Delete)
- ✅ Secure **JWT Authentication & Authorization**
- ✅ API Versioning (v1, v2)
- ✅ Request/Response models with DTOs
- ✅ Object mapping with **AutoMapper**
- ✅ Integrated API documentation with **Swagger / OpenAPI**
- ✅ Global error handling
- ✅ Dependency Injection for services and repositories
- ✅ Async/Await support for scalability

---

## 🛠 Technologies Used

- [.NET 7]
- [ASP.NET Core Web API]
- [Entity Framework Core]
- [SQL Server]
- [JWT Authentication]
- [Swagger / Swashbuckle]
- [AutoMapper]
- C#

---

## 📂 Project Structure
➡️ overview

Solution: MagicVilla (contains 3 projects)

MagicVilla_VillaAPI → This is the ASP.NET Core Web API project. It exposes endpoints (like /api/villa) for CRUD operations.

MagicVilla_Web → This is the ASP.NET Core MVC (or Razor Pages) web project, which consumes the API. It acts as the frontend of the app, calling the API and displaying data in views.

MagicVilla_Utility → This is a shared class library, holding helpers (like SD.cs for constants, API paths, enums, etc.) that are used by both the API and the Web project.

So, the flow of the solution is:

The API project (MagicVilla_VillaAPI) provides REST endpoints.

The Web project (MagicVilla_Web) consumes those endpoints and serves UI to users.

The Utility project (MagicVilla_Utility) contains shared constants/configs that both projects can reuse.

➡️ structure
```plaintext
MagicVilla_API/
├── Controllers/                # API controllers (Villas, VillaNumbers, Users, etc.)
│   ├── v1/                     # API Version 1 controllers
│   └── v2/                     # API Version 2 controllers
│
├── Data/                       # Database context and seeding
│   └── ApplicationDbContext.cs
│
├── Migrations/                 # EF Core migrations for database schema
│
├── Models/                     # Domain models
│   ├── DTOs/                   # Data Transfer Objects
│   ├── Identity/               # ASP.NET Core Identity models
│   └── Villa.cs
│
├── Repository/                 # Repository and Unit of Work
│   ├── IRepository.cs
│   ├── IVillaRepository.cs
│   ├── Repository.cs
│   ├── VillaRepository.cs
│   └── UnitOfWork.cs
│
├── MappingConfig.cs            # AutoMapper configuration
├── Program.cs                  # Application entry point
├── appsettings.json            # Configuration (DB connection, JWT, etc.)
└── MagicVilla_API.csproj       # Project file

