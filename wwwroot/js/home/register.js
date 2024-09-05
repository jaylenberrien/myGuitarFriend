function registerUser(){
    fetch('/Account/Register')
        .then(response => response.text())
        .then(registeredUser =>{
            console.log(registeredUser);
        })
        .catch(error => console.error('Error: ', error));
  
}

