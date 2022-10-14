$(function () {
    $('#submit').on('click', function (evt) {
        document.querySelector('#submit').disabled = true;
        console.log("is it here?");

        var request = $.ajax(
            {
                method: "POST",
                url: "https://localhost:7122/ComicsSeries",
                data: JSON.stringify({ name: "John" }),
                contentType: "application/json",
                dataType: "json"
            });

        request.done(function (msg) {
            alert("Data Saved: " + msg);
        })

        request.fail(function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus + " Error Message: " + jqXHR.responseText);
        })
    });
});