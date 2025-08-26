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

```plaintext
MagicVilla_API/
├── MagicVilla_VillaAPI      # Main Web API project
│   ├── Controllers          # API controllers (v1, v2)
│   ├── Models               # DTOs and domain models
│   ├── Data                 # DbContext and seeding
│   ├── Repository           # Repository pattern implementation
│   └── Mappings             # AutoMapper profiles
