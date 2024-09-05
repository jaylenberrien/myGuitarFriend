function registerUser(){
    fetch('/Account/Register')
        .then(response => response.text())
        .then(newUser =>{
            console.log(newUser)
        })
        .catch(error => console.error('Error: ', error));
  
}

