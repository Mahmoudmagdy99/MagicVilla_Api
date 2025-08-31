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
🏗️ Solution: MagicVilla

The solution contains 3 projects, each with a specific role:

1- MagicVilla_VillaAPI

ASP.NET Core Web API project.

Exposes REST endpoints (e.g., /api/villa) for full CRUD operations.

MagicVilla_Web

2- ASP.NET Core MVC (Razor Pages) project.

Acts as the frontend, consuming the API and rendering data in user-friendly views.

3- MagicVilla_Utility

Shared class library.

Holds reusable helpers such as:

SD.cs → constants & API paths

enums

other utility classes

---

## 🔄 Project Flow

➡️ OverView

API Layer → MagicVilla_VillaAPI provides RESTful endpoints.

UI Layer → MagicVilla_Web consumes these endpoints and serves the UI.

Shared Layer → MagicVilla_Utility centralizes constants and configs used across both API & Web.

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

