function register(){
    fetch('/Account/Register')
    .then(response => response.text())
    .then(accountData =>{
        console.log(accountData);
    })
  
    
}

