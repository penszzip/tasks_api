# Task Management RESTful API

This project is a RESTful API for managing tasks. It allows you to create, read, update, and delete tasks.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core 3.1 or later
- An IDE like Visual Studio Code

### Installing

1. Clone the repository

2. Navigate into the cloned repository

cd yourrepository

3. Restore the .NET packages

dotnet restore

4. Run the application

dotnet run


## API Endpoints

- `GET /api/tasks`: Get all tasks
- `GET /api/tasks/{id}`: Get a task by ID
- `POST /api/tasks`: Create a new task
- `PUT /api/tasks/{id}`: Update a task
- `DELETE /api/tasks/{id}`: Delete a task

## Running the tests

You can run the unit tests for this project by using the following command:


dotnet test
