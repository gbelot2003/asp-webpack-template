import axios from 'axios';
import Login from './Login';


$(document).ready(function () {
    $('#login').on('submit', function (event) {
        Login(event);
    });

    $('#register').on('click', function (event) {
        event.preventDefault();
        var data = {
            Email: "gbelot@clibre.com",
            Password: "Luna0102?",
            ConfirmPassword: "Luna0102?"
        };

        $.ajax({
            type: 'POST',
            url: '/api/Account/Register',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(data)
        }).done(function (data) {
            alert("Done");
        }).fail(showError);
    })
});