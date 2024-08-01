function testCall(){
    fetch('/Notes/Test')
        .then(response => response.text()
        .then(data =>{
            console.log(data)
        }));
    // return console.log("welcome back js, it's been a while");
}