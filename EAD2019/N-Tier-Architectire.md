## Intro N-Tier Architecture

Here are some points to understand

 - **DAL** or `Database Access Logic` Objects should represent your database schema in some way and should be strictly binded to the Database activity.

 - **BLL or BAL** `Business Logic layer` this is place where you should manipulate with data using specific to your project logic. By using this layer, we access the DAL methods to manipulate the data using exposed methods

 - `Presentation layer` objects should be strictly binded to the `Views`. There shouldn't be any logic. These objects should be used only for displaying activities. (related to `MVC`)

**Note** Follow the following links for more understanding 
 - [Creating a Data Access Layer (C#) - DAL](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/data-access/introduction/creating-a-data-access-layer-cs)
 - [Creating a Business Logic Layer (C#)](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/data-access/introduction/creating-a-business-logic-layer-cs)

### Working with Class Library

I will discuss late, how we can create an application (web based or Desktop based appplication e.g. Winforms app) and consume `Class Library` into it with aforementioned N-Tier Architecture.
