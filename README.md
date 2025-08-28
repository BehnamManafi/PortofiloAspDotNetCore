Personal Portfolio Website
A clean and modern personal portfolio website built with ASP.NET Core MVC. It serves as a central hub to showcase your professional information, projects, and articles.

✨ Features
Personal Profile: Display your bio, contact information, skills, and professional experience.

Project Portfolio: Showcase your work with details like project descriptions, technologies used, and live/github links.

Articles/Blog: Write and share articles or blog posts to demonstrate your expertise.

Responsive Design: Built with Bootstrap to ensure a seamless experience on desktop and mobile devices.

Clean Architecture: Organized using the MVC pattern for separation of concerns and maintainability.

🛠️ Built With
Backend Framework: ASP.NET Core

ORM: Entity Framework Core for data access

Database: SQL Server (or SQLite for development)

Frontend: Bootstrap, HTML5, CSS3

IDE: Visual Studio / VS Code

📁 Project Structure
text
Copy
Download
PersonalPortfolio/
├── Controllers/
│   ├── HomeController.cs
│   ├── ProjectsController.cs
│   └── ArticlesController.cs
├── Models/
│   ├── Person.cs
│   ├── Project.cs
│   └── Article.cs
├── Views/
│   ├── Home/
│   ├── Projects/
│   └── Articles/
├── wwwroot/         (CSS, JS, Image files)
└── appsettings.json
🚀 Getting Started
Prerequisites
.NET 8.0 SDK

An IDE (Visual Studio 2022+, VS Code, or Rider)

SQL Server (or use the built-in SQLite for simplicity)
