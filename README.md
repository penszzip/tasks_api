# Task Management RESTful API

This project is a RESTful API for managing tasks. It allows you to create, read, update, and delete tasks.

## Deployment

The API was deployed at Azure cloud app services and is available at:

https://tasksapi20240314215627.azurewebsites.net followed by the route to the endpoint

## API Endpoints

- `GET /tasks`: Get all tasks
- `GET /tasks/{id}`: Get a task by ID
- `POST /tasks`: Create a new task
- `PUT /tasks/{id}`: Update a task
- `DELETE /tasks/{id}`: Delete a task

## Run Locally

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core 3.1 or later
- An IDE like Visual Studio Code

### Installing

1. Clone the repository

2. Navigate into the cloned repository

 - `cd yourrepository`

3. Restore the .NET packages

-  `dotnet restore`

4. Run the application

-  `dotnet run`
