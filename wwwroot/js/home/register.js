function registerUser(){
    fetch('/Account/Register')
        .then(response => response.text())
        .then(registeredUser =>{
            console.log(registeredUser);
        });
  
}

