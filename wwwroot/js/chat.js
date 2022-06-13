"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send buttonl until connection is established.
function activate() {
    $(() => {
        function Afgelopen() {
            console.log(Game.Reversi.getInfo());
            console.log(Game.Reversi.getInfoturn());
            document.getElementById("configMap").setAttribute('value', Game.Reversi.configMap);
            let x = document.getElementById("Result");
            x.classList.remove("hidden");
            let y = document.getElementById("Opgeven");
            y.classList.add("hidden");
            ZetAfgelopen("asdf");
        }
            $('.fiche1').on('click', (event) => {
                console.log(event.target.id);
                $("#table").load(" #table > *");
                $("#table").load(window.location.href + " #table");
            });
            $(document).on('click', '.ZetAfgelopen', function () {
                var id = event.target.id; //if you want to pass an Id parameter
                let usingSplit = id.split('');
                document.getElementById("idrij").setAttribute('value', parseInt(usingSplit[1]));
                document.getElementById("idkolom").setAttribute('value', parseInt(usingSplit[2]));
                document.getElementById("configMap").setAttribute('value', Game.Reversi.configMap);
                document.getElementById("ChartNorm").setAttribute('value', Game.Reversi.getInfoWit(Game.Reversi.getInfo()));
                document.getElementById("ChartAlt").setAttribute('value', Game.Reversi.getInfoturn());

                alert("Het spel is afgelopen");
                var form = document.getElementById("form");
                form.submit();
                ZetSend("afgelopen");

            });
            $(document).on('click', '.Zet', function () {
                var id = event.target.id; //if you want to pass an Id parameter
                let usingSplit = id.split('');
                let test = document.getElementById("Name").innerText;
                document.getElementById("idrij").setAttribute('value', parseInt(usingSplit[1]));
                document.getElementById("idkolom").setAttribute('value', parseInt(usingSplit[2]));
                document.getElementById("configMap").setAttribute('value', Game.Reversi.configMap);
                document.getElementById("ChartNorm").setAttribute('value', Game.Reversi.getInfoWit(Game.Reversi.getInfo()));
                document.getElementById("ChartAlt").setAttribute('value', Game.Reversi.getInfoturn());

                var form = document.getElementById("form");
                form.submit();
                ZetSend("a");
                //Add();
                var x = document.getElementById("form").elements.length;
                var place = document.getElementById(id);

                document.getElementById("rij").innerText = usingSplit[1];
                document.getElementById("kolum").innerText = usingSplit[2];
                //Navigate to the new URL
                if (place.classList.contains("white") || place.classList.contains("black")) {
                } else {
                    Wit:
                    if ("Wit: " + test === document.getElementById("speler1").innerText) {
                        //document.getElementById(event.target.id).classList.add("white")
                    } else {
                        //document.getElementById(event.target.id).classList.add("black")
                    }
                    document.getElementById(event.target.id).classList.add("fade-in");
                }


            });
                    //tegelOnClick(event.currentTarget.offsetLeft);
                    //student uitwerking
        $(document).on('click', '.a', function () {
            console.log(event.target.id);
            // klopt als game.reversi.config
            if (Game.Reversi.configMap.chart == event.target.id) {
                Game.Reversi.configMap.chart = "";
                document.getElementById("myChart").innerHTML = "";
                ReloadChart();
            } else {
                if (event.target.id == "Add") {
                    Game.Reversi.configMap.chart = "Add";

                } else {
                    Game.Reversi.configMap.chart = "Notadd";

                }
                console.log("chart: " + Game.Reversi.configMap.chart)
                try {
                    ShowChart(event.target.id);
                } catch {
                    ReloadChart();
                }
            }

        });
        $(document).on('click', '.ficheoud', function () {
            var id = event.target.id; //if you want to pass an Id parameter
            let usingSplit = id.split('');
            let test = document.getElementById("Name").innerTextl
            document.getElementById("idrij").setAttribute('value', parseInt(usingSplit[1]));
            document.getElementById("idkolom").setAttribute('value', parseInt(usingSplit[2]));
            document.getElementById("configMap").setAttribute('value', Game.Reversi.configMap);
            document.getElementById("ChartNorm").setAttribute('value', Game.Reversi.getInfoWit(Game.Reversi.getInfo()));
            document.getElementById("ChartAlt").setAttribute('value', Game.Reversi.getInfoturn());


            //(rij = document.getElementById("idkolom"));
            //(kolom = usingSplit[2]);
            //rij = parseInt(usingSplit[1]);
            //kolom = parseInt(usingSplit[2]);
            //form.submit();
            var form = document.getElementById("form");

            form.submit();
            //Model.Doezet(Model.spel.ID, rij, kolom);
            ZetSend("Add");
            var x = document.getElementById("form").elements.length;


            var place = document.getElementById(id);

            document.getElementById("rij").innerText = usingSplit[1];
            document.getElementById("kolum").innerText = usingSplit[2];

            //Navigate to the new URL
            if (place.classList.contains("white") || place.classList.contains("black")) {
            } else {
                Wit:
                if ("Wit: " + test === document.getElementById("speler1").innerText) {
                    //document.getElementById(event.target.id).classList.add("white")
                } else {
                    //document.getElementById(event.target.id).classList.add("black")
                }
                document.getElementById(event.target.id).classList.add("fade-in")
            }
            Game.Reversi.addInfo(1411);
        });
    });
}


connection.on("Game", function (message,chart) {
    alert(message);
    //window.location.reload();
    $("#table").load(" #table > *");
    $("#table").load(window.location.href + " #table");

    console.log("chart: " + chart);
    console.log("message: " + message);

    activate();
    // $("#myChart").load(" #myChart > *");
    //$("#myChart").load(window.location.href + " #myChart");
    // my chart al iets geven dus laden
    // chart = "Add" 
    console.log("Game.reversi" + Game.Reversi.configMap.chart);
    ShowChart(Game.Reversi.configMap.chart);

    if (chart != null) {
        //document.getElementById(chart).click();
        //alert("1");
        //Game.Reversi.configMap.chart =  event.target.id;
        //alert("2");
        //document.getElementById(chart).click();
        //alert("3");
    }
    Game.Reversi.configMap.chartInfo = [];
    Game.Reversi.configMap.chartTurn = [];
    if (chat == "NotAdd") {
        //ChartInfo(Game.Reversi.loadInfo(Model.spel.ID));
    }
    if (chat == "Add") { 
        //ChartTurn(Game.Reversi.loadInfo(Model.spel.ID));
    } else {
        //ChartTurn(Game.Reversi.loadInfo(Model.spel.ID));

    }
    $("#table").load(" #table > *");
    $("#table").load(window.location.href + " #table");

    });
connection.on("Afgelopen", function (message, chart) {
    alert(message);("afgelpen chat connection");
    let x = document.getElementById("Result");
    x.classList.remove("hidden");
    x.classList.add("scorecontainer");
    let y = document.getElementById("Opgeven");
    y.classList.add("hidden");
    console.log("tsdsa");
    Afgelopen();
   // window.location.reload();
    

});


connection.on("Restart", function (test) {
    alert("je tegenstander heeft opgegeven");
    //window.location.reload();
    $("#table").load(" #table > *");
    $("#table").load(window.location.href + " #table");
    activate();

});
connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

 
function ZetSend(test) {
    //chart
    function Afgelopen() {
        console.log(Game.Reversi.getInfo());
        console.log(Game.Reversi.getInfoturn());
        document.getElementById("configMap").setAttribute('value', Game.Reversi.configMap);
        let x = document.getElementById("Result");
        x.classList.remove("hidden");
        let y = document.getElementById("Opgeven");
        y.classList.add("hidden");
        ZetAfgelopen("asdf");
    }
    //hier afgelopen
    if (test == "afgelopen") {
         connection.invoke("test", "Je tegenstander heeft een zet gedaan. Het spel is afgelopen", test).catch(function (err) {
            return console.error(err.toString());
        });
   
        Afgelopen();
    } else {
        connection.invoke("test", "Je tegenstander heeft een zet gedaan", test).catch(function (err) {
            return console.error(err.toString());
        });
    }
    //testen

    //connection.invoke("UpdateGame", "Je tegenstander heeft een zet gedaan",test).catch(function (err) {
     //   return console.error(err.toString());
    //});
}
function ZetAfgelopen(test) {
    //chart
    connection.invoke("Afgelopen", "Je tegenstander heeft een zet gedaan", test).catch(function (err) {
        return console.error(err.toString());
    });
    //connection.invoke("UpdateGame", "Je tegenstander heeft een zet gedaan",test).catch(function (err) {
    //   return console.error(err.toString());
    //});
}
function OpgevenSend() {
    connection.invoke("Afgelopen", "Je tegenstander heeft opgegeven","add").catch(function (err) {
        return console.error(err.toString());
    });
}
function Join() {
    connection.invoke("test", "De tweede speler doet mee", "add").catch(function (err) {
        return console.error(err.toString());
    });
}
//function ZetSend() {
  //  connection.invoke("UpdateGame", "a").catch(function (err) {
    //    return console.error(err.toString());
   // });
//}
function Restart() {
    connection.invoke("UpdateGameOthers","sfsd").catch(function (err) {
        return console.error(err.toString());
    });
}

$(() => {

    $('.test').on('click', (event) => {
    //fiche

        console.log(event.target.id);
        var test = document.getElementById("Name").innerText
        console.log("Wit: " + test);

        var id = event.target.id
        let colour = "";
        console.log(document.getElementById("speler1").innerText);
        var place = document.getElementById(event.target.id);
        if (place.classList.contains("white") || place.classList.contains("black")) {
            console.log("test")
        } else {
            if ("Wit: " + test === document.getElementById("speler1").innerText) {
                console.log("1")
                document.getElementById(event.target.id).classList.add("white")
                console.log(event.target.id)
                colour = "wit"
            } else {
                console.log("2")
                document.getElementById(event.target.id).classList.add("black")
                console.log(event.target.id)
                colour = "zwart"
            }
            document.getElementById(event.target.id).classList.add("fade-in")
        }
      
        connection.invoke("SendMessage", colour, event.target.id).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
     

        //tegelOnClick(event.currentTarget.offsetLeft);
    });
    //student uitwerking


});