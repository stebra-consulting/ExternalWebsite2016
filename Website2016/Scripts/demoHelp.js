$(document).ready(function () {
    $("#omStebra").click(function () {
        if (!$("#helper").is(":visible")) {

            $("#helper").show();
        }
        else {

            $("#helper").hide();
        }

    });
    $(".x").click(function () {
        if ($("#colorPicker").is(":visible")) {

            $("#colorPicker").hide();
        }
       

    });
});