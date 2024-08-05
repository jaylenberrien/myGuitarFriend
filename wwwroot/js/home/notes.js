function startRecording(){
    fetch('/Notes/startRec')
        .then(response => response.text())
        .then(startData =>{
            console.log(startData)
        });
    // return console.log("welcome back js, it's been a while");
}

function endRecording(){
    fetch('/Notes/endRec')
        .then(response => response.text())
        .then(endData =>{
            console.log(endData)
        });
    // return console.log("welcome back js, it's been a while");
}