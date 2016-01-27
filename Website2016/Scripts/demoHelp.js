$(document).ready(function () {
    $("h1").click(function () {
        if (!$("#helper").is(":visible")) {

            $("#helper").show();
        }
        else {

            $("#helper").hide();
        }

    });
});