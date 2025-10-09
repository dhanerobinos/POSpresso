# My First Project with Entity Framework Core: POSpresso

POSpresso is my first project using **Entity Framework Core** with **.NET 8 WinForms** and **SQL Server**.  
It’s a Point of Sale (POS) system designed to help small businesses manage products, categories, users, and sales in an intuitive desktop application.

To be able to learn EF Core in this project was a huge advancement of direct-SQL that I were used to before. In this process, I learned about database-first and code-first solutions, asynchronous programming and clean architecture principles as I applied them to a real-life POS system.

## Learning Highlights

### Entity Framework Core Integration
- I learned how to use EF Core as an ORM (Object Relational Mapper) to handle data without writing raw SQL.
This included mapping entities, setting up relationships, and performing CRUD operations in a maintainable way.

### Clean Architecture and OOP Concepts
- Using object-oriented design helped me keep the code tidy, modular, and reusable.
I applied IEntityTypeConfiguration for entity mapping, DTOs for data transfer, and service classes to decouple business logic from the UI.

### Responsive UI with Async/Await
- By using asynchronous EF Core queries, the UI stays responsive even during large data operations.

### Images in Product & Category Management
- Added functionality to create, update, delete, and display products and categories with images, improving the user experience.

### Role-Based User Management
- Implemented admin and cashier roles to provide different access levels within the application.

### Dashboard Charts with WebView2
- Integrated WebView2 to display interactive and modern charts in the Dashboard, making sales insights and best-seller reports visually clear and user-friendly.


This project is not only a functional POS system but also a significant milestone in my learning journey.
It helped me integrate EF Core into a real-world application, structure a WinForms project with clean architecture, and work with SQL Server in a modern and maintainable way.


## Features
- Manage products and categories (with images).
- Role-based user management (Admin & Cashier).
- POS functionality
- Responsive UI with async/await.
- CRUD operations with EF Core.
- Clean architecture with DTOs & services.
- Sales history & reports (daily sales, sales by cashier, top-selling products).
- Dashboard with charts (visual sales overview and top products) using webview2.
- Settings management (general,payment options, and discounts).
