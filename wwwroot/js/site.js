(function () {

    window.toast = {
        success: function (message, title) {
            toastr.success(message, title);
        },
        error: function (message, title) {
            toastr.error(message, title);
        }
    }
    window.myalert = {
        success: function (message, title) {
            Swal.fire(
                title,
                message,
                'success',
            );

        },
        error: function (message, title) {
            Swal.fire(
                title,
                message,
                'error'
            );
        }
    }

})()