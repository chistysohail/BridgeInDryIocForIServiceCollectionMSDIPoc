**.NET 6 Console Application with DryIoc and Microsoft.Extensions.DependencyInjection Integration**
**Overview**
This repository contains a .NET 6 console application demonstrating the integration of DryIoc with Microsoft.Extensions.DependencyInjection. It provides an example of using DryIoc's advanced dependency injection features alongside the conventional Microsoft DI patterns.

**Key Features**
Dependency Injection: Uses DryIoc for robust dependency management along with Microsoft.Extensions.DependencyInjection for standard DI practices.
Service Resolution: Showcases how to register and resolve services using both DryIoc and Microsoft's DI systems, ensuring flexibility and powerful service management.

**Getting Started**
Prerequisites
.NET 6 SDK

**Running the Application**
Clone the repository.
Navigate to the project directory.
Run dotnet restore to install dependencies.
Execute dotnet run to start the application.

**Project Structure**
Program.cs: Main entry point of the application where DI containers are configured and services are resolved.

**Dependencies**
DryIoc.dll: Provides the core functionality for dependency injection.
DryIoc.Microsoft.DependencyInjection: Bridges DryIoc with Microsoft.Extensions.DependencyInjection.
Microsoft.Extensions.DependencyInjection: Implements the basic DI container functionality used by the application.

For further details on using and extending this application, refer to the inline comments within the codebase.
