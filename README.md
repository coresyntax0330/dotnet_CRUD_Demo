## Step 1: Create a New Project

Open terminal (or Visual Studio)

```bash
dotnet new webapi -n CrudDemo
cd CrudDemo
```

## Step 2: Add EF Core & SQLite

Install the required packages

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

### - What is EF Core?

Entity Framework Core (EF Core) is an **object-relational mapper (ORM)** for .NET, developed by Microsoft. It lets developers work with a database using **.NET objects** (classes and properties) instead of writing most raw SQL queries directly.

### - Microsoft.EntityFrameworkCore

This is the **core library** of **Entity Framework Core (EF Core)**. EF Core is an **Object Relational Mapper (ORM)** - it lets you work with a database using **C# objects** instead of writing raw SQL queries.

### - Microsoft.EntityFrameworkCore.Sqlite

A **database provider** for EF Core. EF Core itself is database-agnostic — it can work with SQL Server, PostgreSQL, MySQL, Oracle, or SQLite. Each database requires a provider package.

### - Microsoft.EntityFrameworkCore.Tools

This provides **command-line tools** to manage EF Core — mainly migrations and database updates.

## Step 3: Create the Model

👉 Inside `Models` folder, create `Product.cs`:
