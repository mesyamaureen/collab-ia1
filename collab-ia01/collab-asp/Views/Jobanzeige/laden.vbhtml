
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>laden</title>
</head>
<body>
    <!-- Header -->
    <div>
        <div id="header">
            <a title="zur Startseite" href="Startseite.html">
                <img src="../Bilder/COLLAB-BILD.png" width="300" alt="Collab-Logo" />
            </a>
            <h1 style="font-style: italic;">Collaborate with the right influencer</h1>
        </div>
        <div id="menu">
            <ul style="list-style-type: none;">
                <li class="first">
                    @Html.ActionLink("Startseite", "Index")
                </li>
                <li>
                    @Html.ActionLink("Influencer suchen", "InfluencerSuchen")
                    @*<a href="Influencer suchen.html" accesskey="2" title="Influencer suchen" style="color: black">Influencer suchen</a>*@
                </li>
                <li>
                    @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen")
                    @*<a href="Unternehmen suchen.html" accesskey="3" title="Unternehmen suchen" style="color: black">Unternehmen suchen</a>*@
                </li>
                <li>
                    @Html.ActionLink("Jobanzeigen", "AlleJobanzeigen")
                    @*<a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen" style="color: black">Jobanzeigen</a>*@
                </li>
                <li>
                    @Html.ActionLink("Einloggen", "Einloggen")
                    @*<a href="Einloggen.html" accesskey="5" title="Einloggen" style="color: black">Einloggen</a>*@
                </li>
                <li>
                    @Html.ActionLink("Registrieren", "Registrieren")
                    @*<a href="Registrieren.html" accesskey="6" title="Registrieren" style="color: black">Registrieren</a>*@
                </li>
            </ul>
        </div>
    </div>

    <div id="body">
        <!-- Content fängt hier an -->
        <!-- left Column -->
        <div id="secondaryContentContainer">
            <div id="secondaryContent">
                <ul style="font-size: 16px;">
                    <li id="current">
                        @Html.ActionLink("Startseite", "Index")
                    </li>
                    <li>
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen")
                    </li>
                    <li>
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen")
                    </li>
                    <li>
                        @Html.ActionLink("Jobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li>
                        @Html.ActionLink("Einloggen", "Einloggen")
                    </li>
                    <li>
                        @Html.ActionLink("Impressum", "Impressum")
                        @*<a href="Impressum.html" style="color: black">Impressum</a>*@
                    </li>
                </ul>
            </div>
        </div>

        <!-- middle Column -->
        <!--<div id="primaryContentContainer">-->
        <div id="primaryContent">
            <!-- passt ihr bitte nur diesen Teil an -->
            <div class="parallax">
                <h1 class="center">Meine Jobanzeigen</h1>
                <h2 class="center">Verwalten Sie Ihre Jobanzeigen</h2>
            </div>

            <div id="primaryContentBlock">
                <table id="Tabelle">
                    <tr class="header">
                        <th>Nr</th>
                        <th>Jobtitel</th>
                        <th></th>
                    </tr>

                    @For Each job In Model.Jobanzeige
                            @<tr>
                                <td>@job.Id</td>
                                <td>@job.Titel</td>
                                <td>
                                    @Html.ActionLink("Bearbeiten", "Bearbeiten", New With {.ID = job.Id})
                                     @Html.ActionLink("Löschen", "Loeschen", New With {.ID = job.Id})
                                </td>
                             </tr>
                    Next
                    </table>

                @Html.ActionLink("Hinzufügen", "Hinzufuegen")
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
        <div id = "tertiaryContent" >
            <fieldset id="fldKontakt">
                                            <legend style="font-weight:600;">Brauchen Sie Hilfe?</legend>
                                            <p>Tel.: 030 38 99 00</p>
                                            <p>E-Mail: collab@info.de</p>
            </fieldset>
                        <fieldset id = "fldSocMed" style="margin-top:5em;">
                <legend style = "font-weight:600;" > Folgen Sie uns auch auf:</legend>
                <div id = "socmed" >
                        <!-- Add icon library -->
                        <link rel = "stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

                    <!-- Add font awesome icons -->
                    <a href = "https://www.facebook.com/" Class="fa fa-facebook"></a>
                    <a href = "https://www.instagram.com/" Class="fa fa-instagram"></a>
                    <a href = "https://www.youtube.com/" Class="fa fa-youtube"></a>
                </div>
            </fieldset>
        </div>
    </div>
    <!-- FOOTER -->
    <div id = "footer" >
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
                                                                                                            </div>
</body>
</html>
