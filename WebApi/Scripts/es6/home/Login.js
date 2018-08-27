import axios from 'axios';
import qs from 'qs';

const Login = function (event) {

    event.preventDefault();
    var email = $('#login #email').val();
    var password = $('#login #password').val();

    var loginData = {
        grant_type: "password",
        username: email,
        password: password
    }


    axios.post('/Token', qs.stringify(loginData) , {
        headers: {
            'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
        }
    })
        .then(res => {
            console.log(res);
        });

};
export default Login;