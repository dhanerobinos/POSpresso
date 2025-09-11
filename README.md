# My First Project with Entity Framework Core: POSpresso

POSpresso is my first project using **Entity Framework Core** with **.NET 8 WinForms** and **SQL Server**.  
It’s a Point of Sale (POS) system designed to help small businesses manage products, categories, users, and sales in an intuitive desktop application.

To be able to learn EF Core in this project was a huge advancement of direct-SQL that I were used to before. In this process, I learned about database-first and code-first solutions, asynchronous programming and clean architecture principles as I applied them to a real-life POS system.

- Entity Framework Core Integration
The EF Core project made me acquainted with the ORM (Object Relational Mapper) approach to database handling, EF Core.
I got acquainted with mapping entities, setting up relations, and the CRUD operations do not involve writing raw SQL but is still performance and maintainable.

- Clean Architecture and OOP concepts
The use of object-oriented design has enabled me to maintain code that is tidy, modular and reusable.
I applied `IEntityTypeConfiguration` to entity mapping, `DTOs` to data transfer and service classes to decouple business logic with UI.

- Responsive UI Async/Await
When EF Core queries used asynchronous techniques, I could make the UI feel responsive during data operations of significant size.

- Images Product & Category Management
Applied the ability to add, update, delete and display products and categories with the ability to store and render images to enhance better user experience.

- Role Based User Management
Came up with a system of admin and cashiers users that would allow access to various applications.

- The project was a functional POS system as well as a significant learning curve to me.
It helped me learn to integrate EF Core into a real world application, build a WinForms project with clean architecture and learn to work with SQL Server in a more modern and maintainable fashion.

## Features
- Manage products and categories (with images)
- Role-based user management (Admin & Cashier)
- POS functionality
- Responsive UI with async/await
- CRUD operations with EF Core
- Clean architecture with DTOs & services
-Sales history & reports (daily sales, sales by cashier, top-selling products)
