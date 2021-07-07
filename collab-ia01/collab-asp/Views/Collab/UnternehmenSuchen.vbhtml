
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>UnternehmenSuchen</title>
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
                    @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")
                    @*<a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen" style="color: black">Jobanzeigen</a>*@
                </li>
                <li>
                    @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
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
                <h1 class="center">Unternehmen suchen</h1>
                <h1 class="center">Welches Unternehmen passt zu mir?</h1>
            </div>

            <div id="primaryContentBlock">
                <h2>
                    Branche:<br /> <!-- als Dropdown -->
                    <select name="lstBranche"
                            multiple="multiple" size="5" id="InputLeiste">
                        <option value="1">Anime</option>
                        <option value="2">Autos & Fahrzeuge</option>
                        <option value="3">Beauty & Fashion</option>
                        <option value="4">Bildung</option>
                        <option value="5">DIY</option>
                        <option value="6">Essen</option>
                        <option value="7">Lifestyle</option>
                        <option value="8">Gesundheit</option>
                        <option value="9">Menschen & Blogs</option>
                        <option value="10">Reisen & Events</option>
                        <option value="11">Kunst & Design</option>
                    </select>
                </h2>


                <table id="Tabelle">
                    <tr class="header">
                        <th>Firmenname</th>
                        <th>Branche</th>
                        <th></th>
                    </tr>
                    <tr>
                        <td>Lidl</td>
                        <td>Lebensmitteleinzelhandel</td>
                        <td><button class="button" onclick="location.href='http://localhost:50935/Html/Profil.html';">Profil einsehen</button></td>
                    </tr>
                    <tr>
                        <td>Aldi</td>
                        <td>Lebensmitteleinzelhandel</td>
                        <td><button class="button" onclick="location.href='http://localhost:50935/Html/Profil.html';">Profil einsehen</button></td>
                    </tr>
                    <tr>
                        <td>Hennes und Mauritz</td>
                        <td>Textilhandel</td>
                        <td><button class="button" onclick="location.href='http://localhost:50935/Html/Profil.html';">Profil einsehen</button></td>
                    </tr>
                    <tr>
                        <td>Rossmann</td>
                        <td>Drogerie</td>
                        <td><button class="button" onclick="location.href='http://localhost:50935/Html/Profil.html';">Profil einsehen</button></td>
                    </tr>
                </table>
            </div>
        </div>

        <!--</div>-->
        <!-- right Column-->
        <div id="tertiaryContent">
            <fieldset id="fldKontakt">
                <legend style="font-weight:600;">Brauchen Sie Hilfe?</legend>
                <p>Tel.: 030 38 99 00</p>
                <div class="email">
                    <p>E-Mail:</p>
                    <a href="mailto:collab@info.de" style="font-size: small;">collab@info.de</a>
                </div>
            </fieldset>
            <fieldset id="fldSocMed" style="margin-top:5em;">
                <legend style="font-weight:600;">Folgen Sie uns auch auf:</legend>
                <div id="socmed">
                    <!-- Add icon library -->
                    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

                    <!-- Add font awesome icons -->
                    <a href="https://www.facebook.com/" class="fa fa-facebook"></a>
                    <a href="https://www.instagram.com/" class="fa fa-instagram"></a>
                    <a href="https://www.youtube.com/" class="fa fa-youtube"></a>
                </div>
            </fieldset>
        </div>

    </div>
    <!-- FOOTER -->
    <div id="footer">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>
</body>
</html>
