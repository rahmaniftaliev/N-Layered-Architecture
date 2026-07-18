# Northwind Level Two - Layered Architecture

A sample ASP.NET project demonstrating the **Layered (N-Tier) Architecture** using Entity Framework and ASP.NET MVC/Web API.

## 📂 Project Structure

```
NorthwindLevelTwo
│
├── Business
│   ├── Abstract
│   ├── Concrete
│   └── DependencyResolvers
│
├── Core
│   ├── Utilities
│   ├── CrossCuttingConcerns
│   ├── Aspects
│   └── Extensions
│
├── DataAccess
│   ├── Abstract
│   ├── Concrete
│   └── EntityFramework
│
├── Entities
│   ├── Concrete
│   └── DTOs
│
├── MvcWebUI
│   ├── Controllers
│   ├── Views
│   ├── Models
│   └── wwwroot
│
└── WebAPI
    ├── Controllers
    ├── Middleware
    └── Program.cs
```

---

## 🏛️ Architecture

```
+----------------------+
|      MVC Web UI      |
+----------+-----------+
           |
           |
+----------v-----------+
|       Web API        |
+----------+-----------+
           |
           |
+----------v-----------+
|      Business        |
+----------+-----------+
           |
           |
+----------v-----------+
|     Data Access      |
+----------+-----------+
           |
           |
+----------v-----------+
|      Database        |
+----------------------+

        ▲
        │
+-------+-------+
|   Entities    |
+---------------+

        ▲
        │
+-------+-------+
|     Core      |
+---------------+
```

---

## 🚀 Technologies

- ASP.NET MVC
- ASP.NET Web API
- C#
- Entity Framework
- SQL Server
- LINQ
- Dependency Injection
- Repository Pattern
- SOLID Principles

---

## ✨ Features

- Layered (N-Tier) Architecture
- Repository Pattern
- Dependency Injection
- Entity Framework
- RESTful API
- MVC Front-End
- Clean Separation of Concerns
- Reusable Core Library

---

## 📁 Layer Responsibilities

### Business
Contains business rules, managers, services, and validation logic.

### DataAccess
Responsible for database operations using Entity Framework and Repository Pattern.

### Entities
Contains entity classes and DTOs shared across layers.

### Core
Contains common utilities, helper classes, interfaces, result models, and cross-cutting concerns.

### MvcWebUI
User interface built with ASP.NET MVC.

### WebAPI
REST API endpoints consumed by external applications or the MVC project.

---

## ⚙️ Getting Started

Clone the repository:

```bash
git clone https://github.com/your-username/NorthwindLevelTwo.git
```

Restore packages:

```bash
dotnet restore
```

Run the solution:

```bash
dotnet run
```

---

## 📚 Design Patterns

- Layered Architecture
- Repository Pattern
- Dependency Injection
- SOLID Principles
- Generic Repository
- Service Layer

---

## 📄 License

This project is intended for educational purposes.

---

## ⭐ If you found this project useful, don't forget to give it a star!
