# GameStore REST API
This project implements a REST API to interact with the GameStore database. The API provides endpoints for performing CRUD (Create, Read, Update, Delete) operations on games and genres. It was developed using C# and ASP.NET Core, with SQLite used as the database.

## Overview
The GameStore REST API allows clients to manage games and genres stored in the database. It provides endpoints for retrieving, creating, updating, and deleting games, as well as retrieving genres. The API follows RESTful principles and communicates with clients using JSON.

## Endpoints
- **GET /games**: Retrieves a list of all games.
- **GET /games/{id}**: Retrieves details of a specific game by ID.
- **POST /games**: Creates a new game.
- **PUT /games/{id}**: Updates an existing game.
- **DELETE /games/{id}**: Deletes a game by ID.
- **GET /genres**: Retrieves a list of all genres.

##Technologies Used
- C# Programming Language
- ASP.NET Core Framework
- SQLite Database