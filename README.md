# Student Registration System

A modern desktop-based student registration and department management system built with C# and Windows Forms. The application allows administrators to manage students, departments, and basic dashboard interactions through a clean user interface.

## Overview

This project is designed for academic or institutional use where staff need to:

- Register and manage student records
- Organize departments
- View and update student information
- Maintain data through a desktop application interface
- Track academic-related records efficiently

## Features

- Secure login screen
- Dashboard overview
- Student management module
- Department management module
- Add, update, and delete records
- Data binding with SQL Server LocalDB
- Intuitive Windows Forms interface

## Tech Stack

- C#
- .NET Framework 4.7.2
- Windows Forms (WinForms)
- SQL Server LocalDB
- Guna UI 2 for modern UI components

## Project Structure

```text
Student-Registration-System/
├── Student_Registration_System__/
│   ├── Dashboard.cs
│   ├── Dashboard.Designer.cs
│   ├── Departments.cs
│   ├── Departments.Designer.cs
│   ├── Function.cs
│   ├── Login1.cs
│   ├── Program.cs
│   ├── Students.cs
│   ├── Students.Designer.cs
│   ├── App.config
│   ├── packages.config
│   ├── Student_Registration_System__.csproj
│   └── Properties/
├── packages/
├── README.md
├── Student_Registration_System__.sln
├── .gitattributes
└── .vs/
```

## Database Configuration

The application connects to a LocalDB database using a hardcoded connection string in `Student_Registration_System__/Function.cs`.

Current setup:

```csharp
ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\srimali\Documents\StudentDatabase.mdf;Integrated Security=True;Connect Timeout=30;";
```

To run this project successfully on your machine:

1. Update the database path in `Function.cs` to match your local machine.
2. Ensure SQL Server LocalDB is installed.
3. Create or attach the database file used by the application.
4. Make sure the required tables exist:
   - `StudentTable1`
   - `DepartmentTable1`

## Prerequisites

Before running the project, install:

- Visual Studio 2019 or later
- .NET Framework 4.7.2
- SQL Server LocalDB
- Windows operating system (for WinForms desktop application)

## Installation

1. Clone the repository:

```bash
git clone https://github.com/Srimali-JayaweeraArachchi/Student-Registration-System.git
```

2. Open the solution file:

```text
Student_Registration_System__.sln
```

3. Restore NuGet packages.

4. Build the solution in Visual Studio.

5. Run the application.

## Usage

1. Launch the application.
2. Log in with the configured credentials.
3. Use the dashboard to navigate between modules.
4. Manage student records from the student page.
5. Add, update, or delete department records from the department page.

## Screenshots

Add screenshots here once the app is running locally.

```text
[Application Login Screen]
[Dashboard Screen]
[Students Management Screen]
[Department Management Screen]
```

## Notes

This project is a desktop application and is best suited for Windows environments. The current implementation uses a local database file connection, so if you are running it on another system, you will need to update the connection string and ensure the database schema matches.

## License

This project is currently unlicensed. If you intend to share or publish it publicly, consider adding an appropriate open-source license.

## Author

Srimali Jayaweera Arachchi

## Future Enhancements

- Add role-based authentication
- Improve validation and error handling
- Add search and filtering
- Integrate reports and exports
- Move from LocalDB to a more scalable database solution
- Add unit tests for business logic

---

If you want, I can also help create a more polished version with:

- a project logo section
- badges and shields
- screenshots placeholders
- contributor section
- a downloadable `LICENSE` file
- improved installation instructions for a production-ready setup
