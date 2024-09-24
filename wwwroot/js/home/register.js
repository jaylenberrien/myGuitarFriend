function registerUser(event){
    event.preventDefault();
    // fetch('/Account/Register')
    // .then(response => response.json())
    // .then(newUser =>{ })
    // .catch(error => console.error('Error: ', error));
    const username = document.querySelector("#username-inp");
    const usernameValue = username.value;
    console.log(usernameValue);

    const password = document.querySelector("#password-inp");
    const passwordValue = password.value;
    console.log(passwordValue);

    const body = {
        user: usernameValue,
        pass: passwordValue
    };

    console.log(body);
    console.log("the js page is connected and working");     
}

  

