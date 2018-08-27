import * as Toastr from 'toastr'

function setClickOnButton(e) {
    e.preventDefault();
    Toastr.info('Texto de prueba');
}

$(document).ready(function () {
    $('#prueba').on('click', function (e) {
        setClickOnButton(e);
    })
}) 