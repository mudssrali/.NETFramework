function loadDynamically() {
    
    // selected class id
    var text = $("#cid option:selected").text()
    
    // ajax request prepare
    $.ajax({
        url: "www.example.com",
        data: { classID: cid },
        dataType: "JSON",
        type: "POST",
        success: function (response) {
            
            console.log(response)            
            // need to parse, server returning a string 
            response = JSON.parse(response)
            if (response["status_code"] === 0 || Object.keys(response).length === 0) {
                alert("There is no student against this " + text + " class")
            }
            else {
                // sid is id for student drop-down
                $('#sid').html("");
                var option = $('<option>')
                    .val('').text('Select student')
                $('#sid').append(option);
                for (const key in response) {
                    if (response.hasOwnProperty(key)) {
                        option = $('<option>').val(key).text(response[key]);
                        $('#sid').append(option);
                    }
                }
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
}

/**
 *  structure of the response after parsing will be as below
 *  {
 *      student_id: name
 *  }
 *  e.g.
 *  {
 *     4: abc,
 *     5: cde,
 *     ... 
 *  }   
 */