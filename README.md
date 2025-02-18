# StaffTrack

## Overview
**StaffTrack** is a desktop application designed for employee tracking and management. It helps organizations monitor staff attendance, work schedules, and performance evaluations in a user-friendly environment. Built as a Windows Forms (WinForms) or WPF application, StaffTrack provides an intuitive interface to streamline workforce management.

## Features
- **Employee Management**: Add, edit, and delete employee records.
- **Attendance Tracking**: Log employee check-ins and check-outs.
- **Shift Scheduling**: Assign and modify work shifts for employees.
- **Performance Monitoring**: Evaluate and record employee performance.
- **User Roles & Permissions**: Secure access based on role-based authentication.
- **Reports & Analytics**: Generate reports for workforce insights.
- **Local Database Storage**: Uses SQLite or SQL Server for data persistence.
- **Modern Desktop UI**: Developed using WinForms or WPF for a smooth user experience.

## Technologies Used
- .NET (WinForms / WPF)
- Entity Framework Core (EF Core)
- SQLite / SQL Server
- Windows Presentation Foundation (WPF) or Windows Forms
- MVVM (if using WPF)

## Installation

### Prerequisites
Ensure you have the following installed on your machine:
- [.NET Runtime](https://dotnet.microsoft.com/en-us/download/dotnet)
- [SQL Server or SQLite](https://www.sqlite.org/download.html)
- [Visual Studio](https://visualstudio.microsoft.com/) or a compatible .NET IDE

### Setup Steps
1. Clone the repository:
   ```sh
   git clone https://github.com/your-repository/stafftrack.git
   cd stafftrack
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Set up the database:
   - If using SQLite, ensure the database file is accessible.
   - If using SQL Server, update `appsettings.json` with your connection string.
   - Apply migrations:
     ```sh
     dotnet ef database update
     ```
4. Build and run the application:
   ```sh
   dotnet build
   dotnet run
   ```

## Usage
### Managing Employees
1. Open the application and navigate to the **Employee Management** section.
2. Click **Add Employee** to register a new employee.
3. Use the **Edit** and **Delete** options as needed.

### Tracking Attendance
- Employees check in/out through the **Attendance Module**.
- HR admins can review attendance logs in the **Reports Section**.

### Scheduling Shifts
- Navigate to **Shift Management** to create and update shifts.
- Assign shifts to employees based on department and availability.

### Performance Monitoring
- HR admins can add performance reviews in the **Performance Module**.
- Employees' evaluations are stored and displayed in their profiles.

## Troubleshooting
### Database Connection Issues
If the database does not connect properly:
- Check the connection string in the configuration file.
- Ensure the database service (SQL Server or SQLite) is running.
- Run `dotnet ef database update` to apply migrations.

### Application Crashes
If the application crashes:
- Check for missing dependencies or incorrect .NET version.
- Ensure all required DLLs are included in the application directory.
- Review logs for error messages and stack traces.

## Contributing
We welcome contributions! Please submit a pull request with changes and ensure all tests pass.

## License
This project is licensed under the [MIT License](LICENSE).

---

For further inquiries, contact [itydori@gmail.com](mailto:itydori@gmail.com).

