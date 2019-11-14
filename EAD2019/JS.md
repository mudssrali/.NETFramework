# Intro to JavaScript - ECMAScript

Javascript is client side programming lanaguage which is mainly used to manipulate the `DOM` in any broswer including chrome, firefox, safari etc.

There are three different ways to apply JS to an HTML document that you'll commonly come across

- Inline with element as attributes e.g

    ```html
    <a href="www.example.com" onclick="helloMakeMyDay()">Make My Day</a>
    ```

- At Page level(internal) using `<script>` tag
- In separate `.js` file

### Internal JavaScript using `<script>` tag

```html
 <!DOCTYPE html>
        <head>
            <title>Example - JavaScript</title>
            <script>
                alert("Hello, from head")
                console.log("check your browser's console")
            </script>
        </head>
        <body>
             <script>
                alert("Hello from Body")
                console.log("check your browser's console")
            </script>
            <main class="make-center">

                <h1>HTML Page - JS</h1>
                <p id="make-bold">This is a basic web page with JS.</p>
                <a href="https://twitter.com/voidwebdev" target="_blank">Follow me on Twitter - Mudassar</a>

            </main>
        </body>
    </html>

```
**Note:** JavaScript executes in order e.g. JS in head executes first and the JS in body executes later encapulated in `<script>` tag. [View Demo](./demo-es.html)

### Separate JS `.js` file

Check the following snippet, how to add separate or external `.js` file to includes scripts

```html

    <!DOCTYPE html>
        <head>
            <!-- adding external or separate css file -->
            <script src="./extern-script.js"></script>
            <title>Example Hello World with JS</title>
        </head>
        <body>
            <main>
                <h1>HTML Page</h1>
                <p>This is a basic web page.</p>
                <a href="https://twitter.com/voidwebdev" target="_blank">Follow me on Twitter - Mudassar</a>
            </main>
        </body>
    </html>

```

### `var` Keyword in JS

The var statement declares a variable, optionally initializing it to a value.

```js
    var x = 1;

    if (x === 1) {
    var x = 2;

    console.log(x);
    // expected output: 2
    }

    console.log(x);
    // expected output: 2

```

### Scope of `var`

The scope of a variable declared with var is its `current execution context`, which is either the enclosing function or, for variables declared outside any function, global. If you **re-declare** a JavaScript variable, it will not lose its value.

```js
function x() {
  y = 1; // Throws a ReferenceError in strict mode. In this case will work
  var z = 2;
}

x();

console.log(y); // 1
console.log(z); // Throws a ReferenceError: z is not defined outside x.

```

Note: variable without declare with `var` keyword, is considered `global` in a program or execution context

**Initialization of several variables**

```js
    var x = 0;
    function f() {
    var x = y = 1; // Declares x locally; declares y globally.
    }

    // calling function
    f();

    console.log(x, y); // 0 1
```

### Global Object

A global object is an object that always exists in the global scope.
In JavaScript, there's always a global object defined. In a web browser, when scripts create global variables, they're created as members of the global object.

### `window` object in the Browser

The window object is the Global Object in the Browser. Any Global Variables or Functions can be accessed as properties of the window object.

**Access Global Variables**

```js
    var foo = "foobar";
    foo === window.foo; // Returns: true
```

After defining a `Global Variable` foo, we can access its value directly from the `window` object, by using the variable name `foo` as a **property name** of the Global Object window.foo.

### Basic Data Types

- Number
- Boolean
- Undefined
- Null
- String
- Date
- Array
- Object

### Array in JS

The JavaScript `Array class` is a global object that is used in the construction of arrays; which are high-level, list-like objects.

The JavaScript Array class is a global object that is used in the construction of arrays; which are high-level, list-like objects.

### Common operations

- **Create an Array**

    ```js
        var fruits = ['Apple', 'Banana'];
        console.log(fruits.length);
        // 2
    ```

- **Access (index into) an Array item**

    ```js
    var first = fruits[0];
    // Apple

    var last = fruits[fruits.length - 1];
    // Banana
    ```

- **Loop over an Array**

    ```js
        for(item in fruit) {
        console.log(item);
        });

        // Apple
        // Banana
    ```

- **Add to the end of an Array**

    ```js
        var newLength = fruits.push('Orange');
        // ["Apple", "Banana", "Orange"]
    ```

- **Remove from the end of an Array**

    ```js
    var last = fruits.pop(); // remove Orange (from the end)
    // ["Apple", "Banana"];
    ```

- **Remove from the front of an Array**

    ```js
        var first = fruits.shift(); // remove Apple from the front
        // ["Banana"];
    ```

- **Add to the front of an Array**

var newLength = fruits.unshift('Strawberry') // add to the front
// ["Strawberry", "Banana"];

- **Find the index of an item in the Array**

    ```js
        fruits.push('Mango');
        // ["Strawberry", "Banana", "Mango"]

        var pos = fruits.indexOf('Banana');
    // 1
    ```

- **Remove an item by index position**

    ```js
        var removedItem = fruits.splice(pos, 1); // this is how to remove an item

        // ["Strawberry", "Mango"]
    ```

- **Copy an Array** -  Deep vs Shallow Copy

    ```js
        var deepCopy = fruits // Now I can the value of fruits to by changing the deepCopy elements

        deepCopy.push("Cucumber");

        console.log(fruits.pop()) // remove Cucumber from fruits array. Will it also remove from deepCopy? Yes

        var shallowCopy = fruits.slice(); // this is how to make a copy
        // ["Strawberry", "Mango"]
    ```

### Object in JavaScript

JavaScript is designed on a simple object-based paradigm. An object is a collection of properties, and a property is an association between a name (or key) and a value.

**Objects and properties**

A JavaScript object has properties associated with it. A property of an object can be explained as a variable that is attached to the object.

> objectName.propertyName

```js

    var myCar = new Object();

    myCar.make = 'Ford';
    myCar.model = 'Mustang';
    myCar.year = 1969;


    // same as above

    myCar['make'] = 'Ford';
    myCar['model'] = 'Mustang';
    myCar['year'] = 1969;

```

**Accessing properties of object**

```js

function showProps(obj) {
  var result = ``;
  for (var i in obj) {
    // obj.hasOwnProperty() is used to filter out properties from the object's prototype chain
    if (obj.hasOwnProperty(i)) {
      result += `${objName}.${i} = ${obj[i]}\n`;
    }
  }
  return result;
}

```

So, the function call showProps(myCar) would return the following:

myCar.make = Ford
myCar.model = Mustang
myCar.year = 1969

Following are the links for more detials:

- [Global Object in JS](https://developer.mozilla.org/en-US/docs/Glossary/Global_object#:~:targetText=A%20global%20object%20is%20an,this%20is%20not%20the%20case.))
- [Array() in JS](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array)
- [Object() in JS](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Working_with_Objects)
- [var keyword](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/var)