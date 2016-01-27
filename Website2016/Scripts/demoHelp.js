$(document).ready(function () {
    $("#omStebra").click(function () {
        if (!$("#helper").is(":visible")) {

            $("#helper").show();
        }
        else {

            $("#helper").hide();
        }

    });
    $("#helper").click(function () {
        if ($("#colorPicker").is(":visible")) {

            $("#colorPicker").hide();
        }
        else {
            $("#colorPicker").show();
        }


    });
    $(".x").click(function () {
        if ($("#colorPicker").is(":visible")) {

            $("#colorPicker").hide();
        }
       

    });
    $(".thisColor").click(function () {
        $(".dividers1").css("background-color", $(this).text());
    });

});