# ASP.NET MVC Entity Framework Course Projects

This repository contains two ASP.NET Core projects demonstrating Entity Framework Core concepts: a full **Model-View-Controller** web application and a **Code-First** console application.

---

## Project 1: CarInsurance MVC Application

### Overview
A fully functional ASP.NET Core MVC web application for managing car insurance quotes. Users can create insurance profiles, and the system automatically calculates personalized quotes based on user information.

### Technology Stack
- **Framework**: ASP.NET Core MVC (net10.0)
- **ORM**: Entity Framework Core 10.0.9
- **Database**: SQL Server (LocalDB)
- **Frontend**: Razor Views, Bootstrap 5, jQuery
- **Data Validation**: DataAnnotations, Model Validation

### Features

#### 1. **Insuree Model**
The `Insuree` class represents an insurance applicant with the following properties:
- `Id` (int) - Primary key
- `FirstName` (string) - Required
- `LastName` (string) - Required
- `EmailAddress` (string) - Required, validated with EmailAddress attribute
- `DateOfBirth` (DateTime) - Required
- `CarYear` (int) - Required
- `CarMake` (string) - Required
- `CarModel` (string) - Required
- `DUI` (bool) - Flag for DUI history
- `SpeedingTickets` (int) - Count of speeding violations
- `CoverageType` (string) - Type of insurance coverage
- `Quote` (decimal) - Auto-calculated monthly premium

#### 2. **Quote Calculation Engine**
The `CalculateQuote()` method in `InsureeController` implements a tiered pricing model:

**Base Quote**: $50/month

**Age-Based Surcharges**:
- 18 and under: +$100
- 19–25: +$50
- 26+: +$25

**Vehicle Age Surcharges**:
- Before 2000: +$25
- After 2015: +$25

**Make/Model Surcharges**:
- Porsche: +$25
- Porsche 911 Carrera: additional +$25 (total $50)

**Violations**:
- Each speeding ticket: +$10

**DUI**:
- 25% multiplier on total quote

**Coverage Type**:
- Full coverage: 50% multiplier on total quote

#### 3. **CRUD Operations**
**InsureeController** provides standard Create, Read, Update, Delete operations:
- **Index**: List all insurees with their quotes
- **Details**: View a single insuree's full information
- **Create**: Add a new insuree (auto-calculates quote)
- **Edit**: Modify existing insuree information (auto-recalculates quote)
- **Delete**: Remove an insuree record
- **Admin**: Administrator view showing first name, last name, email, and quote summary

#### 4. **User Interface**
- **Views/Insuree/Index.cshtml**: List view with Edit, Details, and Delete action buttons
- **Views/Insuree/Create.cshtml**: Form for new applicants; displays notice that quote is auto-calculated
- **Views/Insuree/Edit.cshtml**: Modify existing applicant; shows read-only calculated quote
- **Views/Insuree/Details.cshtml**: View applicant details with formatted quote
- **Views/Insuree/Delete.cshtml**: Confirmation page before deletion
- **Views/Insuree/Admin.cshtml**: Summary table for administrators (name, email, quote)

#### 5. **Navigation**
The shared layout (`Views/Shared/_Layout.cshtml`) includes navigation links:
- Home
- Insurees
- Admin
- Privacy

### Database Setup

**Connection String** (appsettings.json):
```
Server=(localdb)\mssqllocaldb;Database=CarInsuranceDb;Trusted_Connection=True;MultipleActiveResultSets=true
```

**DbContext** (Models/CarInsuranceContext.cs):
```csharp
public class CarInsuranceContext : DbContext
{
    public DbSet<Insuree> Insurees { get; set; }
}
```

**Migrations**:
- Initial migration: `20260624090455_InitialCreate`
- Database created via EF Core Code-First approach

### Running the MVC Application

1. Ensure SQL Server LocalDB is installed and running.
2. Navigate to the project directory:
   ```powershell
   cd "c:\Users\Hp\work space\CarInsurance"
   ```
3. Build and run:
   ```powershell
   dotnet run
   ```
4. Access the application at `https://localhost:5001` (or `http://localhost:5000`)

---

## Project 2: StudentCodeFirst Console Application

### Overview
A minimal Entity Framework Code-First console application demonstrating database creation and data seeding. Creates a `StudentCodeFirstDb` with a `Students` table and inserts one sample student record.

### Technology Stack
- **Framework**: .NET Console Application (net10.0)
- **ORM**: Entity Framework Core 10.0.9
- **Database**: SQL Server (LocalDB)

### Components

#### 1. **Student Model**
```csharp
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
}
```

#### 2. **SchoolContext DbContext**
```csharp
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
```

#### 3. **Program Logic**
- Uses `DbContextOptionsBuilder` to configure SQL Server connection
- Calls `context.Database.EnsureCreated()` to create the database and schema if not present
- Checks if students exist; if none, adds Alice Johnson with today's enrollment date
- Displays all students in the database

### Database Configuration

**Connection String**:
```
Server=(localdb)\mssqllocaldb;Database=StudentCodeFirstDb;Trusted_Connection=True;MultipleActiveResultSets=true
```

### Running the Console Application

1. Navigate to the project directory:
   ```powershell
   cd "c:\Users\Hp\work space\CarInsurance\StudentCodeFirst\StudentCodeFirst"
   ```
2. Run the application:
   ```powershell
   dotnet run
   ```
3. Expected output:
   ```
   Added student Alice Johnson.
   1: Alice Johnson (6/24/2026)
   ```

---

## Project Structure

```
c:\Users\Hp\work space\CarInsurance\
├── CarInsurance/                          # Main MVC application
│   ├── Controllers/
│   │   ├── HomeController.cs
│   │   └── InsureeController.cs
│   ├── Models/
│   │   ├── Insuree.cs
│   │   ├── CarInsuranceContext.cs
│   │   └── ErrorViewModel.cs
│   ├── Views/
│   │   ├── Insuree/
│   │   │   ├── Index.cshtml
│   │   │   ├── Create.cshtml
│   │   │   ├── Edit.cshtml
│   │   │   ├── Details.cshtml
│   │   │   ├── Delete.cshtml
│   │   │   └── Admin.cshtml
│   │   ├── Home/
│   │   ├── Shared/
│   │   │   └── _Layout.cshtml
│   │   └── _ViewImports.cshtml
│   ├── wwwroot/                           # Static assets
│   ├── Migrations/                        # EF migrations
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   ├── Program.cs
│   └── CarInsurance.csproj
│
└── StudentCodeFirst/StudentCodeFirst/     # Code-First console app
    ├── Models/
    │   ├── Student.cs
    │   └── SchoolContext.cs
    ├── Program.cs
    └── StudentCodeFirst.csproj
```

---

## Learning Outcomes

### MVC Concepts
- **Model**: Defined strong-typed entity classes with data annotations
- **View**: Created Razor views for CRUD operations with Bootstrap styling
- **Controller**: Implemented business logic, including automatic quote calculation

### Entity Framework Core
- **Code-First Approach**: Defined models first, generated database via migrations
- **DbContext**: Managed database connections and entity relationships
- **Migrations**: Applied database schema changes with EF Core tooling
- **LINQ**: Queried and manipulated data asynchronously

### Database Design
- **LocalDB**: Configured SQL Server Express LocalDB for development
- **Data Annotations**: Applied validation attributes (Required, EmailAddress, Range)
- **Decimal Precision**: Configured `Quote` column as `decimal(18,2)` for accurate currency values

### ASP.NET Core
- **Dependency Injection**: Constructor injection of DbContext into controller
- **Data Binding**: Automatic model binding in POST actions
- **Validation**: Server-side validation with ModelState checks
- **Anti-Forgery**: Applied `[ValidateAntiForgeryToken]` to form submissions

---

## How to Deploy

### Prerequisites
- .NET 10.0 SDK or later
- SQL Server or SQL Server LocalDB
- Visual Studio Code or Visual Studio 2022

### Steps
1. Clone or download the projects
2. Install dependencies:
   ```powershell
   dotnet restore
   ```
3. Configure connection strings in `appsettings.json`
4. Apply migrations (if needed):
   ```powershell
   dotnet ef database update
   ```
5. Build and run:
   ```powershell
   dotnet run
   ```

---

## Future Enhancements

- Add authentication and authorization
- Implement role-based access control for admin features
- Add unit tests for quote calculation logic
- Create API endpoints for external integrations
- Add data export functionality (CSV, PDF)
- Implement email notifications for quote generation

---

**Course**: ASP.NET MVC Entity Framework  
**Date**: June 24, 2026  
**Platform**: .NET 10.0
# C-Projects
