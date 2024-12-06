# FinancialFlowManager

## Overview
FinancialFlowManager is a project designed to manage financial transactions and provide daily consolidated reports. The architecture focuses on scalability, maintainability, and adherence to best practices such as Domain-Driven Design (DDD) and Clean Code principles.

## Key Features
- **Transaction Management**: Create, read, update, and delete (CRUD) financial transactions.
- **Daily Consolidation**: Automatically calculate daily aggregated balances based on transactions.
- **Authentication and Authorization**: Secured with JWT Bearer Authentication.
- **Documentation**: API documentation with Swagger UI, including JWT support.
- **Error Handling and Logging**: Centralized logging with Serilog (to be implemented).

## Architectural Patterns and Practices
The project utilizes modern architectural patterns and practices to ensure a robust and scalable solution:

1. **Event Sourcing**:
   - Tracks changes as a sequence of events.
   - Ensures auditability and allows easy state reconstruction.

2. **Domain Events**:
   - Captures and propagates significant changes in the domain.
   - Decouples business logic from event processing.

3. **Domain-Driven Design (DDD)**:
   - Models entities, aggregates, and value objects based on business concepts.

4. **Domain Notifications**:
   - Provides a mechanism for notifying application layers about business rule violations.

5. **Domain Validations**:
   - Ensures business rules are enforced at the domain level using FluentValidator.

6. **Unit of Work**:
   - Manages transactional operations for consistency in data persistence.

7. **CQRS (Command Query Responsibility Segregation)**:
   - Separates read and write operations for optimized data access and scalability.

## Technologies Used

### Core Framework and Tools
- **ASP.NET 8.x**: Utilized for building a scalable and robust web API.
- **ASP.NET WebApi Core**: RESTful API development.
- **JWT Bearer Authentication**: Secure authentication mechanism.
- **ASP.NET Identity Core**: User management and identity functionality.

### Data Access
- **Entity Framework Core 8.x**: ORM for managing database interactions.
- **Dapper**: Lightweight and efficient data access tool (planned for implementation).

### Dependency Injection and Mediation
- **.NET Core Native DI**: Built-in dependency injection for managing service lifetimes.
- **MediatR**: Facilitates decoupled communication between objects.

### Mapping and Validation
- **AutoMapper**: Simplifies object-to-object mapping.
- **FluentValidator**: Implements domain-level validations.

### API Documentation
- **Swagger UI**: Interactive API documentation with JWT token support.

### Logging and Monitoring
- **Serilog**: Structured and centralized logging (to be implemented).

## Getting Started

### Prerequisites
- **.NET 8 SDK**
- **SQL Server** or any other relational database.
- **Postman** (optional, for API testing).

### Running the Application Locally

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/financialflowmanager.git
   cd financialflowmanager
   ```

2. **Set Up the Database**:
   - Configure the connection string in `appsettings.json`.
   - Run the migrations:
     ```bash
     dotnet ef database update
     ```

3. **Build and Run the Application**:
   ```bash
   dotnet build
   dotnet run
   ```

4. **Access the API Documentation**:
   - Navigate to `http://localhost:5000/swagger` to view and interact with the API documentation.

### Key Endpoints
- **Authentication**:
  - `POST /api/auth/login`: Authenticate and receive a JWT token.
- **Transactions**:
  - `GET /api/transactions`: Retrieve a list of transactions.
  - `POST /api/transactions`: Create a new transaction.
- **Daily Consolidation**:
  - `GET /api/consolidations`: Retrieve daily consolidated balances.

## Project Structure
The solution is organized as follows:

```
FinancialFlowManager
│
├── FinancialFlowManager.Domain
│   ├── Entities
│   ├── ValueObjects
│   ├── Interfaces
│   └── Events
│
├── FinancialFlowManager.Application
│   ├── Commands
│   ├── Queries
│   └── Services
│
├── FinancialFlowManager.TransactionsService
│   └── API Controllers
│
├── FinancialFlowManager.ConsolidationService
│   └── API Controllers
│
├── FinancialFlowManager.Infrastructure
│   ├── Data Contexts
│   ├── Migrations
│   └── Repositories
│
├── FinancialFlowManager.CrossCutting
│   ├── Logging
│   ├── Configuration
│   └── DependencyInjection
│
└── FinancialFlowManager.Tests
    ├── UnitTests
    └── IntegrationTests
```

## Future Enhancements
- **Dapper Implementation**: Improve performance in read-heavy operations.
- **Serilog Integration**: Add centralized logging with support for structured data.
- **Distributed Caching**: Use Redis to optimize read operations.
- **Message Queues**: Introduce RabbitMQ or Kafka for asynchronous event handling.
- **Performance Testing**: Validate system behavior under high load scenarios.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request with your changes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

