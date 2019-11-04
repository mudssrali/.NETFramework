## Basics of C-Sharp

### Using Keyword

The using keyword has three major uses:

 - The `using statement` defines a scope at the end of which an object will be disposed.
   ```
   using(var Learn = new Learning()) {
       Learn.Add("Learning in Fun")
       Learn.Add("Happy Coding")
       Learn.Save()
   }
   ```
   **Note** - After the above code snippet, `Object` of `Learning` will automatically be destroyed

 - The `using directive` creates an alias for a namespace or imports types defined in other namespaces.
   
   > using namespace Hello;

 - The `using static directive` imports the members of a `single class`.
   
   > using static <`fully-qualified-type-name`>;

### Intro to Enumerable Objects and Generic Collections

Will discuss later


### LINQ Code Examples

 - Linear Search using Loops on Array or Objects - `LINQ Folder`
 - Query using LINQ - visit `LINQ Folder`
 - Using `lambda expression` with LINQ - vist `Lambda-Expression Folder`