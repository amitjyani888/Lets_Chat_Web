function adduser()
 {

    user_name = document.getElementbyId("user_name").value;
    localstorage = ("user_name", user_name);
window.location = "kwitter_room.html";
 }