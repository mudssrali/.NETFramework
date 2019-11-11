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

### Separate CSS style `.css` file

Check the following snippet, how to add separate or external `.css` file to includes styles

```html

    <!DOCTYPE html>
        <head>
            <!-- adding external or separate css file -->
            <script src="s./extern-script.js"></script>
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