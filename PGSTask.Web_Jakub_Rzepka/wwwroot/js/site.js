$(document).ready(() => {

    $(document).on("click", "#submitBtn", () => {
        if ($("#submitInput").val()) $("#submitForm").submit();
        else $("#submitInput").effect("highlight", { color: '#ff4207' });
    });

    //debugger;
    //$(document).on("click", ".customEditIcon", () => {
    //    var name = $(this).attr('name');
    //    $(name).hide();

        //var r = confirm("Are you sure to delete this task?");
        //if (r == true) $("#" + formId).submit();
    //});

});