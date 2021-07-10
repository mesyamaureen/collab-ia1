﻿@ModelType collab_asp.Benutzer

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Einloggen</title>
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
            <h1 style="text-align: center;">Loggen Sie sich jetzt ein!</h1>


            <div id="formular" class="parallax">
                @Using Html.BeginForm("Einloggen", "AlleProfile", FormMethod.Post)
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary(True)
                    @<div>
                        @Html.LabelFor(Function(m) m.Benutzername)
                        @Html.TextBoxFor(Function(m) m.Benutzername)
                        @Html.ValidationMessageFor(Function(m) m.Benutzername)
                    </div>
                    @<div>
                        @Html.LabelFor(Function(m) m.Passwort)
                        @Html.TextBoxFor(Function(m) m.Passwort)
                        @Html.ValidationMessageFor(Function(m) m.Passwort)
                    </div>

                    @<div>
                        @Html.ActionLink("Passwort vergessen", "Einlogen")
                        <input type="submit" value="Login" />
                    </div>

                End Using
            </div>
        </div>
        <!--</div>-->
        <!-- right Column-->
        <div id = "tertiaryContent" >
            <fieldset id="fldKontakt">
        <legend style="font-weight:600;">Brauchen Sie Hilfe?</legend>
        <p>Tel.: 030 38 99 00</p>
        <div class="email">
            <p>E-Mail:</p>
            <a href="mailto:collab@info.de" style="font-size: small;">collab@info.de</a>
                </div>
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
