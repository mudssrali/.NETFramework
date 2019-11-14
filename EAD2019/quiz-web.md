## HTML Quiz

- [W3 School- Quiz on HTML](https://www.w3schools.com/quiztest/quiztest.asp?qtest=HTML)
- [HTML Quiz](https://www.proprofs.com/quiz-school/quizshow.php?title=html-basics-quiz_1)

## CSS Quiz

## JS Quiz

- **what is the difference between `===` and `==`?**

  Both used to compare values whether equal or not, but `===` also compare the type of the value (if type mismatch, result will be false). Following code shows the difference

  ```js

    var a = 5
    var b = 5
    var c = "5" // string
    if(a==b)
        console.log("Hello I'm equal")

    if(a==c)
        console.log("Hello I'm equal too")

    if(a===c)
        console.log("Hawwwwww, I'm unequal :p")

  ```

- **What is the correct JavaScript syntax to change the content of the HTML element below?**

    ```html
    <p id="demo">This is a demonstration.</p>
    ```

    Answer:

    ```js
    window.document.getElementById("demo").innerHTML = "Hello World"
    ```

- **Where is the correct place to insert a JavaScript?**

    Both inside `<head>` and `<body>` tags of the html page

- **How do you create a function in JavaScript?**

    > var myFunc = new Function()

    and will be called as *myFunc()*

- **What is the correct way to write a JavaScript array?**

    Here are two simple ways

    > var myArray = ["Cat", "Coding", "Dark Mode"]

    > var myArray = new Array("Cat", "Coding", "Dark Mode")

    Output: will be same of above snippets

- **How do you round the number 7.25, to the nearest integer?**

    > Math.round(7.25) // 7

- **What will the following code return: Boolean(10 > 9)**

    > true

- **Is JavaScript case-sensitive?**

    > Yes

- **What will be the output of the following?**

    ```html
        <script>
        console.log(new Array(5).toString())
        </script>
    ```

    output: `,,,,` // four times comma, because 1,2,3,4,5

- **What will be the output of the** `"1" - "1"`

    answer: 0 // because treated as integer, similary "1" - "2" will output -1

- **What will be the output of the** `String('Hello') === 'Hello'`

    answer: true

- **What will be the result of the** `willNumber("1")-1 == 0`

    answer: true

- **What will be the result of the** `10 > 9 > 8 === true`

    answer: false // 10 > 9 will return true so true > 8 will result in false

- **Output of the code below, convert to Number**

    ```html

    <!DOCTYPE html>
    <html>
        <body>

            <p>Click the button to convert variables to numbers.</p>

            <button onclick="myFunction()">Try it</button>

            <p id="demo"></p>

            <script>
            function myFunction() {
            var x1 = true;
            var x2 = false;
            var x3 = new Date();
            var x4 = "999";
            var x5 = "999 888";

            var n = 
            Number(x1) + "<br>" + 
            Number(x2) + "<br>" + 
            Number(x3) + "<br>" + 
            Number(x4) + "<br>" + 
            Number(x5);
            document.getElementById("demo").innerHTML = n;
            }
            </script>

        </body>
    </html>

    ```

    Output:

    ```html
    1
    0
    1573705365118
    999
    NaN

    ```

### Some addition tweaks

- Output of `5 + "5" => 55` // plus used for string concatenation

- Output of `5 - "5" => 0` // "5" converted to number, implicit conversion

- Output of `5 * "5" => 25`

- Output of `+"5" + 5 => 10` // +"5" converted to number, explicit conversion