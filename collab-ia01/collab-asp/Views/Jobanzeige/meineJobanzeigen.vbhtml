@ModelType collab_asp.JobanzeigenListe

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <title>Meine Jobanzeigen</title>
</head>
<body>
    <!-- Header -->
    <div>
        <div id="header" style="background-color: #ECECEC;">
            <a title="zur Startseite" href="Startseite.html">
                <img src="../Bilder/COLLAB-BILD.png" width="300" alt="Collab-Logo" />
            </a>
            <h1 style="font-style: italic;">Collaborate with the right influencer</h1>
            <div>
                <ul class="nav justify-content-end">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
                        @*<a href="Influencer suchen.html" accesskey="2" title="Influencer suchen" style="color: black">Influencer suchen</a>*@
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen", "AlleUnternehmen")
                        @*<a href="Unternehmen suchen.html" accesskey="3" title="Unternehmen suchen" style="color: black">Unternehmen suchen</a>*@
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")
                        @*<a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen" style="color: black">Jobanzeigen</a>*@
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                        @*<a href="Einloggen.html" accesskey="5" title="Einloggen" style="color: black">Einloggen</a>*@
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Registrieren", "Registrieren")
                        @*<a href="Registrieren.html" accesskey="6" title="Registrieren" style="color: black">Registrieren</a>*@
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <div class="container-fluid" style="background-color:#FFCCBC;">
        <!-- Content fängt hier an -->
        <!-- left Column -->
        <div class="row">
            <div class="col-2">
                <ul class="nav flex-column">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen", "AlleUnternehmen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Jobanzeigen", "AlleJobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Impressum", "Impressum")
                        @*<a href="Impressum.html" style="color: black">Impressum</a>*@
                    </li>
                </ul>
            </div>

            <!-- middle Column -->
            <!--<div id="primaryContentContainer">-->
            <div class="col-md-8" style="background-color:#ECECEC;">
                <!-- passt ihr bitte nur diesen Teil an -->
                <div class="container-fluid">
                    <div class="jumbotron">
                        <div class="parallax">
                            <h1 class="center">Meine Jobanzeigen</h1>
                            <h2 class="center">Verwalten Sie Ihre Jobanzeigen</h2>
                        </div>
                    </div>

                    <div id="primaryContentBlock">
                        <div class="panel-body">
                            <table class="table table-striped table-bordered" id="Tabelle">
                                <tr class="header">
                                    <th>Nr</th>
                                    <th>Jobtitel</th>
                                    <th></th>
                                </tr>


                                @For Each job In Model.Jobanzeige 'hier Model.alle öffentlichen Properties
                                    @<tr>
                                        <td>@job.JobID</td>
                                        <td>@job.Titel</td>
                                        <td>
                                            @Html.ActionLink("Bearbeiten", "Bearbeiten", Nothing, New With {.ID = job.JobID}, New With {.class = "btn btn-primary btn-sm", .role = "button"})
                                            @Html.ActionLink("Löschen", "Loeschen", Nothing, New With {.ID = job.JobID}, New With {.class = "btn btn-danger btn-sm", .role = "button"})
                                        </td>
                                    </tr>
                                Next
                            </table>
                        </div>
                        <div class="text-center">
                            @Html.ActionLink("Hinzufügen", "Hinzufuegen", Nothing, New With {.class = "btn btn-primary", .role = "button"})
                        </div>
                    </div>
                </div>
            </div>

            @*<tr>
                        <td>1</td>
                        <td>#LidlStudio - Lidl sucht Influencer!</td>
                        <td><input type = "button" Class="button" value="Löschen" onclick="javascript: confirm('Möchten Sie wirklich löschen?');" /><button Class="button" onclick="location.href='http://localhost:50935/Html/Bewerbung.html';">Bearbeiten</button></td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>#LidlMitte - Zeig uns deine Shopping-Liste</td>
                        <td><input type = "button" Class="button" value="Löschen" onclick="javascript: confirm('Möchten Sie wirklich löschen?');" /><a href="#" id="button-bearb" Class="button">Bearbeiten</a></td> <!--<button id="button-bearb" Class="button" onclick="location.href='http://localhost:50935/Html/Bewerbung.html';">Bearbeiten</button>-->
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>Nachhaltig mit Lidl</td>
                        <td><input type = "button" Class="button" value="Löschen" onclick="javascript: confirm('Möchten Sie wirklich löschen?');" /><button Class="button" onclick="location.href='http://localhost:50935/Html/Bewerbung.html';">Bearbeiten</button></td>
                    </tr>
                    <tr>
                        <td>4</td>
                        <td>#LidlVegan - Für die Erde und meine Gesundheit</td>
                        <td><input type = "button" Class="button" value="Löschen" onclick="javascript: confirm('Möchten Sie wirklich löschen?');" /><button Class="button" onclick="location.href='http://localhost:50935/Html/Bewerbung.html';">Bearbeiten</button></td>
                    </tr>
                </table>

                <div Class="center">
                    <!-- CSS, aber wie navigiert man zur nächsten Seite weiter? (warte bis VL: Javascript) Stand: 28.04.2021 -->
                    <Button Class="button">Hinzufügen</button>
                </div>

                <div Class="bg-modal">
                    <div Class="modal-content">
                        <div Class="close">x</div>
                        <h2> Bearbeiten</h2>
                        <form action = "" >
                            <input type="text" placeholder="Titel"/>
                                        <input type = "text" placeholder="Beschreibung" />
                            <a href = "" Class="button">Speichern</a>
                        </form>
                    </div>
                </div>

                <Script>
                                        document.getElementById('button-bearb').addEventListener('click', function() {
                        document.querySelector('.bg-modal').style.display = 'flex';
                    });

                    document.querySelector('.close').addEventListener('click', function () {
                        document.querySelector('.bg-modal').style.display = 'none';
                    });
                </script>
            </div>
        </div>*@
            <!--</div>-->
            <!-- right Column-->
            <div class="col-2" style="background-color:#FFCCBC;">
                <fieldset id="fldKontakt">
                    <legend style="font-weight:600;">Brauchen Sie Hilfe?</legend>
                    <p>Tel.: 030 38 99 00</p>
                    <p>E-Mail: collab@info.de</p>
                </fieldset>
                <fieldset id="fldSocMed" style="margin-top:5em;">
                    <legend style="font-weight:600;"> Folgen Sie uns auch auf:</legend>
                    <div id="socmed">
                        <!-- Add icon library -->
                        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

                        <!-- Add font awesome icons -->
                        <a href="https://www.facebook.com/" Class="fa fa-facebook"></a>
                        <a href="https://www.instagram.com/" Class="fa fa-instagram"></a>
                        <a href="https://www.youtube.com/" Class="fa fa-youtube"></a>
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
    <!-- FOOTER -->
    <div id="footer" class="text-center">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>


    <!-- Option 2: JavaScript -->
    @*<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>*@

    <!-- Bootstrap Bundle with Popper -->
    @*<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>*@

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
</body>
</html>
