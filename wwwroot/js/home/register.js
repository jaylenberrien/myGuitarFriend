async function registerUser(event){
    // we are going to put the logic to get the user info first

    //after we are going to setup the actual post req

    //we also have our responses to decide on, review what they are and decide if we need them
    event.preventDefault();

    fetch('/Account/Register')
    .then(response => response.json())
    .then(newUser =>{ 



    })
    .catch(error => console.error('Error: ', error));


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

    console.log("the js page is connected and working");     
}

  

