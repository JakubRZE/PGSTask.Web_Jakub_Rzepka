$(document).ready(() => {

    var token = $('input[name="__RequestVerificationToken"]').val();


    HandleAddTaskButton();

    HandleEditTaskButton();

    HandleSubmitEditTaskButton(token);
});

function HandleAddTaskButton() {
    $(document).on("click", "#submitBtn", () => {
        if ($("#submitInput").val()) $("#submitForm").submit();
        else $("#submitInput").effect("highlight", { color: '#ff4207' });
    });
}

function HandleEditTaskButton() {
    $(document).on("click", ".customEditIcon", (event) => {

        var taskId = $(event.currentTarget).attr('name');
        var descInputName = "input[name='" + taskId + "']";
        var subEditBtnId = '#' + taskId + '';

        $(descInputName).attr("readonly", false);
        $(event.currentTarget).hide();
        $(subEditBtnId).show();
        $(descInputName).focus();
    });
}

function HandleSubmitEditTaskButton(token) {
    $(document).on("click", ".customDoneIcon", (event) => {

        var taskId = $(event.currentTarget).attr('id');
        var descInputName = "input[name='" + taskId + "']";

        if ($(descInputName).val()) {
            var editBtn = "[name = '" + taskId + "']";

            $(descInputName).attr("readonly", true);
            var newDesc = $(descInputName).val();
            $(event.currentTarget).hide();
            $(editBtn).show();

            SubmitEditForm(token,taskId, newDesc);
        }
        else {
            $(descInputName).effect("highlight", { color: '#ff4207' }).focus();
        }
    });
}

function SubmitEditForm(token,taskId, desc) {

    event.preventDefault();
    event.stopImmediatePropagation();

    $.ajax({
        url: '/UserTask/Edit',
        method: 'POST',
        contentType: 'application/x-www-form-urlencoded; charset=utf-8',    
        dataType: 'json',
        data: {
            __RequestVerificationToken: token,
            id: taskId,
            description: desc
        },
        success: (response) => {
            if (response.success) {
                $("[name = '" + response.responseText + "']").effect("highlight", { color: '#02d402' });
            } else {
                $("[name = '" + response.responseText + "']").effect("highlight", { color: '#ff4207' });
            }
        },
        error: () => { alert('Something goes worng:(') }
    });


};
