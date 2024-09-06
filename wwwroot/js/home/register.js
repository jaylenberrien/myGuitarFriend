function registerUser(event){
    fetch('/Account/Register')
        .then(response => response.json())
        .then(newUser =>{
            // event.preventDefault();
            const username = document.getElementById("username-inp");
            const usernameValue = username.value;
            console.log(usernameValue);
            const password = document.getElementById("password-inp");
            const passwordValue = password.value;
            console.log(passwordValue);
            console.log(newUser);
        })
        .catch(error => console.error('Error: ', error));



  
}

