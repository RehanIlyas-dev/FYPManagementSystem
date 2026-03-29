# FYP Management System

A Windows Forms desktop application for managing Final Year Projects (FYP) in an academic environment. Built with .NET 10 and MySQL, it provides a centralized platform to manage students, advisors, projects, groups, and evaluations.

## Features

- **Student Management** -- Add, update, and remove student records with registration details.
- **Advisor Management** -- Manage advisors with designation and salary information.
- **Project Management** -- Create and track FYP projects with descriptions.
- **Group Management** -- Organize students into project groups with status tracking.
- **Project-Advisor Assignment** -- Assign advisors to projects with roles (Main Advisor, Co-Advisor, Industry Advisor).
- **Project-Group Assignment** -- Link groups to their respective projects.
- **Evaluation System** -- Define evaluations with marks/weightage and record group evaluation results.
- **Reports** -- Generate and view project-related reports.

## Tech Stack

| Component   | Technology                  |
|-------------|-----------------------------|
| Language    | C# (.NET 10)                |
| UI          | Windows Forms               |
| Database    | MySQL 8.0                   |
| ORM/Data    | MySql.Data, ADO.NET         |
| Architecture| 3-Tier (UI, BL, DL)         |

## Project Structure

```
FYPManagementSystem/
├── Models/          # Data models (Student, Advisor, Project, Group, Evaluation, etc.)
├── BL/              # Business Logic layer
├── DL/              # Data Access layer (MySQL via ADO.NET)
├── UI/              # Windows Forms user interface
│   ├── Main/        #   Main dashboard
│   ├── Students/    #   Student CRUD forms
│   ├── Advisors/    #   Advisor CRUD forms
│   ├── Projects/    #   Project CRUD forms
│   ├── Groups/      #   Group management forms
│   ├── GroupProject/ #  Project-Group assignment
│   ├── ProjectAdvisor/ # Advisor-Project assignment
│   └── Evaluations/ #   Evaluation & grading forms
├── Reports/         # Report generation (BL, DL, UI)
├── Database.sql     # Full database schema with seed data
└── App.config       # Connection string configuration
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [MySQL 8.0+](https://dev.mysql.com/downloads/)

## Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/RehanIlyas-dev/middb26_2025-cs-65.git
   cd FYPManagementSystem
   ```

2. **Create the database**
   ```bash
   mysql -u root -p < Database.sql
   ```

3. **Configure the connection string** in `App.config`:
   ```xml
   <connectionStrings>
     <add name="ProjectDbConnection"
          connectionString="server=localhost;port=3306;database=projectadb26;user=root;password=YOUR_PASSWORD;"
          providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
   ```

4. **Build and run**
   ```bash
   dotnet build
   dotnet run
   ```

## Database Schema

The application uses a relational MySQL database (`projectadb26`) with the following core tables:

| Table             | Purpose                              |
|-------------------|--------------------------------------|
| `person`          | Base entity for students & advisors  |
| `student`         | Student-specific data (Reg. No.)     |
| `advisor`         | Advisor designation & salary         |
| `project`         | FYP project title & description      |
| `group`           | Student groups                       |
| `groupstudent`    | Group membership with status         |
| `groupproject`    | Project-Group assignments            |
| `projectadvisor`  | Advisor-Project role assignments     |
| `evaluation`      | Evaluation definitions (marks)       |
| `groupevaluation` | Recorded evaluation results          |
| `lookup`          | Reference data (Gender, Status, Designation, Advisor Role) |

## License

This project is developed for academic purposes and is open source.