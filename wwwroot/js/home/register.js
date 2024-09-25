async function registerUser(event){
    // we are going to put the logic to get the user info first

    //after we are going to setup the actual post req

    //we also have our responses to decide on, review what they are and decide if we need them
    event.preventDefault();

    const username = document.querySelector("#username-inp");
    const usernameValue = username.value;
    console.log(usernameValue);

    const password = document.querySelector("#password-inp");
    const passwordValue = password.value;
    console.log(passwordValue);

    //this might turn out to be useless
    // const body = {
    //     user: usernameValue,
    //     pass: passwordValue
    // };

    const request1 = await fetch('/Account/Register',{
        method: "POST",
        body: JSON.stringify({
            username: usernameValue,
            password: passwordValue
        })
    })
    .then(response => response.json())
    .then(data => console.log(data)) 
    .catch(error => console.error('Error: ', error));
    //const response1 = await fetch(request1);
    //console.log(response1.status)
    


    

    //console.log("the js page is connected and working");     
}

  

