# Inventory Management System

A complete desktop + web-ready inventory system built with .NET

## Features
- Desktop application (Windows Forms)
- RESTful API (ASP.NET Core Web API)
- SQL Server database with Entity Framework Core
- Login system
- Manage Products, Categories, Suppliers, Stock History
- Clean architecture (separated layers)

## Projects
- **InventoryManagementSys** → Windows Forms Desktop App (Main UI)
- **API** → ASP.NET Core Web API (Backend services)
- **Datalayer** → Shared models and database context

## Technologies
- C# .NET 8
- Entity Framework Core (Code First)
- SQL Server / LocalDB
- Windows Forms
- HTTP Client for API calls

## How to Run

### 1. Run the API (Backend)
1. Open solution in Visual Studio 2022
2. Set **API** project as startup project
3. Press F5 → API will run on https://localhost:7xxx
4. First run creates database + admin user:
   - Username: `admin`
   - Password: `1234`

### 2. Run the Desktop App
1. Set **InventoryManagementSys** (WinForms) as startup project
2. Press F5
3. Login with admin / 1234
4. Enjoy!

## Future Plans
- Add JWT Authentication
- Web version (Blazor/React)
- Reports & Printing
- User roles & permissions

Made with love for small businesses, shops, and warehouses
