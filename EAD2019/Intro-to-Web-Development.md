## Intro HTML

## Intro CSS

## Intro JavaScript

## Intro to jQuery

jQuery is a fast, small, and feature-rich JavaScript library. It makes things like HTML document traversal and manipulation, event handling, animation, and Ajax much simpler with an easy-to-use API that works across a multitude of browsers.

- .ready()
- .remove()
- .append()
- .css()
- .attr()
- .click()
- .closset()
- .bind()
- .undbind()
- .find()
- .one()
- .addClass()
- .removeClass()
- **.html(string?)** -  use to `manipulate` or `get` the html of the `DOM` element

    1.Get all instances of `<button>` element and change their **HTML** to `Hello World`

    > $("button").html( "Hello World")

    2.Get the instance of `<button>` element with class `continue` and change its **HTML** to `Hello World`

    > $("button.continute").html("Hello World")

    3.Get all elements with class `bold` and change their **HTML** to `jQuery Magic`

    > write here

    4.Get all elements with with id 'color' and change their **HTML** to `id est`

    > $("#color").html("id est") // does it work, why and why not?

- **.val(string?)** - use to `get` the value or `set` the value of `DOM` element

    1.Get the value of `input` element having class `name`

    > $("name").val()

    2.Get the value of `input` element having id `name`

    > $("#name").val()

    3.Get the value of all `input` elements having class `input`

    > $(".input").val() // does it work, why or why not?

    4.Set the value of `input` element having class `name`to `jQuery Prac`

    > $("name").val("jQuery Prac")

    5.Set the value of `input` element having id `name` to `Hello World`

    > // write your answer here

    6.Set the value of all `input` elements having class `input`

    > // will discuss it

- **.text()** - Get the combined text contents of each element in the set of matched elements, including their descendants

    consider the following HTML

    ```

    <div class="container">
        <div class="box">Demonstration Box</div>
        <ul>
            <li>list item 1</li>
            <li>list <strong>item</strong> 2</li>
        </ul>
    </div>
    ```

    > $("div.container").text() // what would be the result of this script line

    Note: The `.text()` method cannot be used on form inputs or scripts. To set or get the text value of `input` or `textarea` elements