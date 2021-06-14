function validate() {
    // first name at least 2 char
    let fname = document.getElementById('firstname');
    if (fname.value.length <= 2) {
        message.innerHTML = 'First name must be at least 2 characters';
        return false;
    }

    // last name at least 2 char
    let lname = document.getElementById('lastname');
    if (fname.value.length < 2) {
        message.innerHTML = 'First name must be at least 2 characters';
        return false;
    }

    // valid email: use regex (at least 2 chars, at symbol, at least 2 chars, period, at least 2 chars)
    let email = document.getElementById('email');
    let re = /^[a-zA-Z0-9]{3,}@@[a-zA-Z0-9]{2,}\.[a-zA-z0-9]{2,}$/;
    if (email.value.match(re) == null) {
        message.innerHTML = 'Please enter a valid email';
        return false;
    }

    // password must have 1 capitol letter one lowercase letter one number and one symbol
    let pass = document.getElementById('password');
    let ree = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W)/;
    if (pass.value.match(ree) == null) {
        message.innerHTML = 'Password must contain an uppercase letter, a lowercase letter, a number, and a special character';
        return false;
    }

    // password.value.match(conpass) = true if match or null if not <-- issue if not
    let conpass = document.getElementById('conpass');
    if (conpass.value != pass.value) {
        message.innerHTML = 'Passwords don\'t match';
        return false;
    }

    message.innerHTML = '';
    return true;
}