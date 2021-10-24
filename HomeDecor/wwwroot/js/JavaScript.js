$(document).ready(function () {
    $('#GetProductDetails').click(function () {

        $.ajax({
            url: "http://" + window.location.host + "/api" + '/GetProductDetails/' + $(this).attr("title"),
            type: "GET",
            dataType: "JSON",
            success: function (result) {
                console.log(result);
            }
        });
    })
});