# Library Api 
# Project: Book/Library Management System

## This project has been developed using the following technologies and design patterns:
  ### Technology Stack:
       Backend Framework: .NET 5
       Architecture: Clean Architecture
       CQRS (Command Query Responsibility Segregation): Implemented to separate command and query responsibilities
       Database Access: Utilizing Entity Framework Core (for ORM) and Dapper (for microservices or specific scenarios)
       Repository Pattern: Implemented to provide a standard approach to data access

  ### Authentication and Authorization:
       Authentication: Utilizing JWT (JSON Web Tokens)
       Authorization: Implementing role-based authorization to control access to various functionalities
      
  ### Components:
       Book Management:
            Registration of books
            Querying all books
            Querying a specific book
            Removing a book
       User Management:
            User registration 
            Querying all users
            Querying a specific user
       Loan Management:
            Loan registration 
            Returning a book (PLUS 2)
            Querying a specific Loan

            
