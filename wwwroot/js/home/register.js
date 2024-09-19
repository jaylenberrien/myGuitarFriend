function registerUser(event){
    event.preventDefault();
    fetch('/Account/Register')
        .then(response => response.json())
        .then(newUser =>{
            
            console.log("the js page is connected and working");

            const username = document.querySelector("username-inp");
            const usernameValue = username.value;
            console.log(usernameValue);

            const password = document.querySelector("password-inp");
            const passwordValue = password.value;
            console.log(passwordValue);

            console.log(newUser);
            
        })
        .catch(error => console.error('Error: ', error));


const testbtn = document.querySelector("testy");
testbtn.addEventListener("click", testFunc);

function testFunc(event){
    const hugeContainer = document.querySelector("huge-container");
    hugeContainer.style.backgroundColor = "green";
}
  
}

