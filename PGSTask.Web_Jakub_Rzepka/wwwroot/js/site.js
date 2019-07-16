$(document).ready(() => {

    $(document).on("click", "#submitBtn", () => {
        if ($("#submitInput").val()) $("#submitForm").submit();
        else $("#submitInput").effect("highlight", { color: '#ff4207'});
    });

});