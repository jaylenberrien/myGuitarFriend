function startRecording(){
    fetch('/Notes/startRec')
        .then(response => response.text()
        .then(data =>{
            console.log(data)
        }));
    // return console.log("welcome back js, it's been a while");
}

function endRecording(){
    fetch('/Notes/endRec')
        .then(response => response.text()
        .then(data =>{
            console.log(data)
        }));
    // return console.log("welcome back js, it's been a while");
}