$('.BlockServer').on("click", function (element) {

    let selectedServer = $(element.target).parent().parent();
    let userInput = selectedServer.find('.UserInput');

    if (!userInput.val()) {
        userInput.addClass('error');
        return;
    }
    userInput.removeClass('error');

    $.ajax({
        url: "/Home/BlockServer",
        type: "POST",
        data: JSON.parse(JSON.stringify({
            serverDTO: { Name: selectedServer.find('.ServerName').html().trim(), User: { Name: selectedServer.find('.UserInput').val() } }
        })),
        success: function (response) {
            selectedServer.find('.UserInput').val(response.BlockedBy);
            selectedServer.find('.UserInput').attr('hidden', 'hidden');
            selectedServer.find('.UserName').html(response.BlockedBy);
            selectedServer.find('.ReleaseServer').removeAttr("disabled");
            selectedServer.find('.BlockServer').attr("disabled", "disabled");

        }
    })
});

$('.ReleaseServer').on("click", function (element) {

    let selectedServer = $(element.target).parent().parent();
    let currentUser = $('#UserId').val();
    $.ajax({
        url: "/Home/ReleaseServer",
        type: "POST",
        data: JSON.parse(JSON.stringify({
            serverDTO: { Name: selectedServer.find('.ServerName').html().trim(), User: { Name: currentUser } }
        })),
        success: function (response) {
            selectedServer.find('.UserInput').val(currentUser);
            selectedServer.find('.UserInput').removeAttr('hidden');
            selectedServer.find('.UserName').html('');
            selectedServer.find('.ReleaseServer').attr("disabled", "disabled");
            selectedServer.find('.BlockServer').removeAttr("disabled");
        }
    })
});

$('.UserInput').on('focus', function (event) {
    $(event.currentTarget).removeClass('error');
})