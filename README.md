# WebAppTemplate

An ASP.NET Core MVC portfolio web application with an administrative dashboard for managing website content.

## Overview

WebAppTemplate is a full-stack web application built with ASP.NET Core MVC.

The project contains two main parts:

- Public portfolio website
- Admin dashboard for managing website content

The admin dashboard allows authenticated users to manage different sections of the portfolio, such as:

- About
- Skills
- Positions
- Education
- Certificates
- Portfolio
- Testimonials
- Clients
- Fun Facts
- Social Media

The project was built to practice and demonstrate common ASP.NET Core concepts and application architecture.

## Features

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- Authentication and Authorization
- Admin Area
- CRUD operations
- Generic Repository Pattern
- Dependency Injection
- ViewModels
- Extension Methods for object mapping
- Entity relationships
- EF Core Migrations
- File Upload
- Email Service
- Soft Delete
- EF Core SaveChanges Interceptor
- Razor Views
- Model Validation

## Architecture

The application follows an MVC-based architecture with additional layers for data access and object mapping.

```text
Browser
   │
   ▼
ASP.NET Core Middleware Pipeline
   │
   ▼
Routing
   │
   ▼
Controller
   │
   ▼
Repository
   │
   ▼
Entity Framework Core
   │
   ▼
SQL Server
