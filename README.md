# Library Api 
## Project: Book/Library Management System

### This technology stack and architecture provide a scalable, maintainable, and secure solution for the Book/Library Management System, including authentication and authorization mechanisms using JWT.
### This project has been developed using the following technologies and design patterns:
### 1 - Technology Stack:
       Backend Framework: .NET 7
       Architecture: Clean Architecture
       CQRS (Command Query Responsibility Segregation): Implemented to separate command and query responsibilities
       Database Access: Utilizing Entity Framework Core (for ORM) and Dapper (for microservices or specific scenarios)
       Repository Pattern: Implemented to provide a standard approach to data access

### 2 - Authentication and Authorization:
       Authentication: Utilizing JWT (JSON Web Tokens)
       Authorization: Implementing role-based authorization to control access to various functionalities
      
### 3 - Components:
       Book Management
            Registration of books
            Querying all books
            Querying a specific book
            Removing a book
       User Management
            User registration 
            Querying all users
            Querying a specific user
            User Login
       Loan Management
            Loan registration 
            Returning a book 
            Querying a specific Loan

### 4 - Implementation Notes:

    * Clean Architecture principles have been followed to separate concerns and dependencies.
    * CQRS has been implemented to handle commands and queries separately.
    * Entity Framework Core has been used for the ORM aspect of data access.
    * Dapper has been integrated for scenarios where raw SQL or microservices require a lightweight data access approach.
    * A repository pattern has been implemented to ensure standardized data access throughout the application.

## Registration of books
![create_book](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/3ff9ac7c-6b90-450c-a0c7-3686376b48ac)

## User Login
![login](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/16b921ab-0871-47d5-87bf-897cee2ca0e5)

## Authorization 
![block](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/4be39767-ff80-4932-929d-5f4a4ceb0c43)

## Borrow a book
![loan](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/ed8d0ab6-0717-4f74-974d-4512f6acac79)

## Retrun a book 
![return book1](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/953cf1e0-f6d7-493c-8042-c8aa4892235b)

## Get All User - Dapper 
![getAll](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/6cca3e9e-bd06-4982-b842-8b1bdeb244b9)

## Swagger
![swagger api li](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/96141a08-4601-498d-859c-268e7efbf140)

## Directory Structure
![estrutura das pastas](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/65bb26aa-4816-49ca-95f6-30cf6e73c4ac)

### How to run: Download the project and run Update-Database in the Library.Api 
