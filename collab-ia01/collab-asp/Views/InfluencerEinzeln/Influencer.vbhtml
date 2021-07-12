﻿@ModelType collab_asp.Influencer

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Influencer</title>
</head>
<body>
    <!-- Header -->
    <div>
        <div style="background-color: #ECECEC;">
            <a title="zur Startseite" href="Startseite.html">
                <img src="../Bilder/COLLAB-BILD.png" width="300" alt="Collab-Logo" />
            </a>
            <h1 style="font-style: italic;">Collaborate with the right influencer</h1>
            <div>
                <ul class="nav justify-content-end align-items-end">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
                        @*<a href="Influencer suchen.html" accesskey="2" title="Influencer suchen" style="color: black">Influencer suchen</a>*@
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen", "AlleUnternehmen")
                        @*<a href="Unternehmen suchen.html" accesskey="3" title="Unternehmen suchen" style="color: black">Unternehmen suchen</a>*@
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")
                        @*<a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen" style="color: black">Jobanzeigen</a>*@
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                        @*<a href="Einloggen.html" accesskey="5" title="Einloggen" style="color: black">Einloggen</a>*@
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Registrieren", "Registrieren")
                        @*<a href="Registrieren.html" accesskey="6" title="Registrieren" style="color: black">Registrieren</a>*@
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <!-- Contents -->
    <!-- Left Column -->
    <div class="container-fluid" style="background-color:#FFCCBC;">
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

            <!-- Middle Column -->
            <div class="col-8">
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.BenutzerID)
                    @Html.TextBoxFor(Function(m) m.BenutzerID, New With {.readonly = "readonly", .class = "form-control-plaintext"})
                    @Html.ValidationMessageFor(Function(m) m.BenutzerID)
                </div>
            </div>

            <!-- Right Column -->
            <div class="col-2">
                <div class="col-2" style="background-color:#FFCCBC;">
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
        </div>
    </div>

    <!-- FOOTER -->
    <div class="text-center mt-lg-5">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>

    <!-- Bootstrap bundle -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
</body>
</html>
