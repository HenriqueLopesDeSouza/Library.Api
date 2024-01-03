# Library Api 
# Project: Book/Library Management System

## This project has been developed using the following technologies and design patterns:
### 1 - Technology Stack:
       Backend Framework: .NET 5
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
       Loan Management
            Loan registration 
            Returning a book (PLUS 2)
            Querying a specific Loan

### 4 - Implementation Notes:

    * Clean Architecture principles have been followed to separate concerns and dependencies.
    * CQRS has been implemented to handle commands and queries separately.
    * Entity Framework Core has been used for the ORM aspect of data access.
    * Dapper has been integrated for scenarios where raw SQL or microservices require a lightweight data access approach.
    * A repository pattern has been implemented to ensure standardized data access throughout the application.


##
## This technology stack and architecture provide a scalable, maintainable, and secure solution for the Book/Library Management System, including authentication and authorization mechanisms using JWT.


## Registration of books
![create_book](https://github.com/HenriqueLopesDeSouza/Library.Api/assets/43977679/3ff9ac7c-6b90-450c-a0c7-3686376b48ac)



