function startRecording(){
    fetch('/Notes/StartRec')
        .then(response => response.text())
        .then(startData =>{
            console.log(startData)
        });
    // return console.log("welcome back js, it's been a while");
}

function endRecording(){
    fetch('/Notes/EndRec')
        .then(response => response.text())
        .then(endData =>{
            console.log(endData)
        });
    // return console.log("welcome back js, it's been a while");
}