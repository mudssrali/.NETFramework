## Basics of C-Sharp

### namespace

A namespace is a collection of classes. The HelloWorldApp `namespace` contains the class HelloWorld

```C#
   using System;

   namespace HelloWorldApp {
      class HelloWorld {
         static void Main(string[] args) {
            /* my first program in C# */
            Console.WriteLine("Hello World");
            Console.ReadKey();
         }
      }
   }
```

### var keywaord

Local variables can be declared without giving an `explicit type`. The `var` keyword instructs the compiler to infer the type(implicit) of the variable from the expression on the right side of the initialization statement

```C#

   // i is compiled as an int
   var i = 5;

   // s is compiled as a string
   var s = "Hello";

   // a is compiled as int[]
   var a = new[] { 0, 1, 2 };

   // expr is compiled as IEnumerable<Customer>
   // or perhaps IQueryable<Customer>
   var expr =
      from c in customers
      where c.City == "London"
      select c;

   // anon is compiled as an anonymous type
   var anon = new { Name = "Terry", Age = 34 };

   // list is compiled as List<int>
   var list = new List<int>();
```

**Note:** The var keyword may be used in the following contexts:

- On local variables (variables declared at method scope) as shown in the previous example.

- In a `for` initialization statement.

   > for(var x = 1; x < 10; x++)

- In a `foreach` initialization statement.

   > foreach(var item in list){...}

- In a `using` statement

   > using (var file = new StreamReader("C:\\myfile.txt")) {...}

### using Keyword

The `using` keyword has three major uses:

 - The `using statement` defines a scope at the end of which an object will be disposed.
   ```
   using(var Learn = new Learning()) {
       Learn.Add("Learning in Fun")
       Learn.Save()
       Learn.Add("Happy Coding")
   }
   ```
   **Note** - After the above code snippet, `Object` of `Learning` will automatically be destroyed

 - The `using directive` creates an alias for a namespace or imports types defined in other namespaces.
   
   > using namespace Hello;

 - The `using static directive` imports the members of a `single class`.
   
   > using static <`fully-qualified-type-name`>;

**Note:** C# source files typically have the file extension .cs

### Types of Variable

The variables in C#, are categorized into the following types

- `Value` types (bool, byte, int, long, char, decimal, double etc.)
- `Reference` types (Object, dynamic, String)
- `Pointer` types (char* cptr, int* iptr)

Note: Difference between `Object` and `dynamic` type

### Type Conversion

- `Implicit` type conversion
- `Explicit` type conversion

### Classes and objects

 A class is a data structure that combines state (`fields`) and actions (`methods` and other `function members`) in a single unit. A class provides a definition for `dynamically created instances` of the class, also known as `objects`. Classes support `inheritance` and `polymorphism`, mechanisms whereby derived classes can extend and specialize base classes.

The following is a declaration of a simple class named `Point`:

```C#
   public class Point
   {
      public int x, y;
      public Point(int x, int y) 
      {
         this.x = x;
         this.y = y;
      }
   }
```

**Institiation**: Instances of classes are created using the `new` operator, which allocates memory for a new instance, invokes a `constructor` to initialize the instance, and returns a `reference` to the instance
```C#
Point p1 = new Point(0, 0);
Point p2 = new Point(10, 20);
```
### Base Classes

```C#
   public class Point
   {
      public int x, y;
      public Point(int x, int y) 
      {
         this.x = x;
         this.y = y;
      }
   }
   public class Point3D: Point
   {
      public int z;
      public Point3D(int x, int y, int z) : base(x, y) 
      {
         this.z = z;
      }
   }
```
### Referrence and Output parameters

- **Refference parameters**

   A reference parameter is used for passing arguments by `reference`. The argument passed for a reference parameter must be a variable with a `definite value`. A reference parameter is declared with the `ref` modifier.

   ```C#
      using System;
      class RefExample
      {
         static void Swap(ref int x, ref int y) 
         {
            int temp = x;
            x = y;
            y = temp;
         }
         public static void SwapExample() 
         {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // Outputs "2 1", String interplotion is used here to output,
            //Console.WriteLine("{0} {1}",i, j) // Outputs "2 1"
         }
      }

   ```

- **Outp ut parameters**

   An output parameter is used for passing arguments by reference. It's similar to a reference parameter, except that it doesn't require that you explicitly assign a value to the caller-provided argument. An output parameter is declared with the out modifier.

   ```C#
   using System;
      class OutExample
      {
         static void Divide(int x, int y, out int result, out int remainder)
         {
               result = x / y;
               remainder = x % y;
         }
         public static void OutUsage() 
         {
               Divide(10, 3, out int res, out int rem);
               Console.WriteLine("{0} {1}", res, rem);	// Outputs "3 1"
         }
      }
   }

   ```

### Accessibility (Access Specifiers)

   Each member of a class has an associated accessibility, which controls the regions of program text that are able to access the member. There are six possible forms of accessibility. These are summarized below.

- `public`
   Access not limited
- `protected`
   Access limited to this class or classes derived from this class
- `internal`
   Access limited to the current assembly (.exe, .dll, etc.)
- `protected internal`
   Access limited to the containing class, classes derived from the containing class, or classes within the same assembly
- `private`
   Access limited to this class
- `private protected`
   Access limited to the containing class or classes derived from the containing type within the same assembly

### Interfaces

   An interface defines a contract that can be implemented by classes and structs. An interface can contain methods, properties, events, and indexers. An interface does not provide implementations of the members it defines.

   ```C#
   interface IControl
   {
      void Paint();
   }
   interface ITextBox: IControl
   {
      void SetText(string text);
   }
   interface IListBox: IControl
   {
      void SetItems(string[] items);
   }
   interface IComboBox: ITextBox, IListBox {}
   ```

   **Note:** Classes and structs can implement multiple interfaces

   ```C#
   interface IDataBound
   {
      void Bind(Binder b);
   }
   public class EditBox: IControl, IDataBound
   {
      public void Paint() { }
      public void Bind(Binder b) { }
   }
   ```

### Intro to Enumerable Objects and Generic Collections

Will discuss later

### LINQ Code Examples

- Linear Search using Loops on Array or Objects - `LINQ Folder`
- Query using LINQ - visit `LINQ Folder`
- Using `lambda expression` with LINQ - vist `Lambda-Expression Folder`