function getAllUsers() {
    $.ajax('https://localhost:44396/api/MyUsers',
        {
            dataType: 'json', // type of response data
            success: function (data, status, xhr) { // success callback function
                //on vide le tableau
                $("#allUsers").empty();
                data.forEach(user => {
                    let nom = user.name;
                    let prenom = user.firstname;
                    let mail = user.mail;

                    $("#allUsers").append("<p>" + nom + " " + prenom + " " + mail + "</p>")
                });
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback
                alert(errorMessage);
            }
        });
}

function getAllTodoItems() {
    $.ajax('https://localhost:44396/api/TodoItems',
        {
            dataType: 'json', // type of response data
            success: function (data, status, xhr) { // success callback function
                $("#allTodoItems").empty();
                data.forEach(i => {
                    let item = i.name;
                    let check = i.isComplete;

                    $("#allTodoItems").append("<p>" + item + " " + check + "</p>")
                });
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback
                alert(errorMessage);
            }
        });

}

function createUser() {
    //Récupère les valeurs du formulaire
    let nomInput = $("#NomUser").val();
    let prenomInput = $("#PrenomUser").val(); //Le body de notre requête
    let formData = {
        "name": nomInput,
        "firstname": prenomInput
    }; //On lance la requête
    $.ajax('https://localhost:44396/api/MyUsers',
        {
            type: 'POST',
            dataType: 'json', // type of response data
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(formData),
            success: function (data, status, xhr) { // success callback function
                getAllUsers();
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback
                alert(errorMessage);
            }
        });
}

function createItem() {
    //Récupère les valeurs du formulaire
    let nomItem = $("#NomItem").val();
    let statutItem = $("#isCompleteItem").is(':checked'); //Le body de notre requête
    let formData = {
        "name": nomItem,
        "isComplete": statutItem
    }; //On lance la requête
    $.ajax('https://localhost:44396/api/TodoItems',
        {
            type: 'POST',
            dataType: 'json', // type of response data
            headers: {
                "Content-Type": "application/json"
            },
            data: JSON.stringify(formData),
            success: function (data, status, xhr) { // success callback function
                getAllTodoItems();
            },
            error: function (jqXhr, textStatus, errorMessage) { // error callback
                alert(errorMessage);
            }
        });
}

