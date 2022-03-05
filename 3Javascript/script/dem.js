function demoExternalAlert(){
    alert("External Alert.");
}
function demoExternalConfirm(){
    if(confirm("External are you sure.??")){
        alert("YESSS");
    }
    else{
        alert("NOOOO");
    }
}
function demoExternalPrompt(){
    var fName=prompt("Enter Firstname Here..");
    var lName=prompt("Enter Lastname Here..");
    alert(fName+" "+lName);
}