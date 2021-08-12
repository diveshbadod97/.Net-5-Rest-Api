# .Net-5-Rest-Api

* Creating end to end REST API from scratch using .NET 5
* API written in C#

### Entity, Repository, Controller GET
* Adding an entity
* Ading an in-memory repository
* Creating the controller
* Implemeting GET all items
* Implemeting GET single item
* Returning a 404 NotFound status code

## Dependency Injection, DTOSs
* Extracting the repository interface
* Injecting the repository into the controller
* Registering the repository as a singleton
* Adding a Data Transfer Object DTO
* Creating the AsDto extension method

### POST, PUT, DELETE
* Implementing POST
* Adding validations via data annotations
* Implemeting PUT
* Implementing DELETE

### Persisting Entities with MongoDB
* Creating a MongoDB repository
* Using the MongoDB.Driver NuGet package
* Implementing MongoDB Create
* Running the MongoDB Docker container
* Configuring MongoDB connection settings
* Registering the MongoClient singleton
* Testing the MongoDB integration
* Exploring the created database in VS Code
* Implemeting MongoDB Get, Update and Delete

### Tasks, Async and Await
* Using the Async suffix
* Using tasks in the repository
* Using async and await
* Returning completed tasks
* Using tasks in the controller
* Testing async methods in Postman
