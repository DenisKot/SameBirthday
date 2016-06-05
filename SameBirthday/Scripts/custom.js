function setLableValue(lbname, value) {
    document.getElementById(lbname).innerHTML = value;
}

$("document").ready(function() {
    $('#monthes-list a').click(function (e) {
        var txt = $(e.target).text();
        var value = $(e.target).attr("value");
        $("#lbMonth").html(txt);
        $("#inputMonth").val(value);
    });
});