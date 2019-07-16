$(document).ready(() => {

    $(document).on("click", "#submitBtn", () => {
        if ($("#submitInput").val()) $("#submitForm").submit();
        else $("#submitInput").effect("highlight", { color: '#ff4207'});
    });

    $(document).on("click", ".customBinIcon", () => {
       var r = confirm("Are you sure to delete this task?");
        if (r == true) $("#deleteForm").submit();
    });

});