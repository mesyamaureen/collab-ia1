@ModelType collab_asp.Unternehmen

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
    <title>MeinProfilUnternehmer</title>
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
        <div>
            <ul class="nav justify-content-end">
                <li class="nav-item">
                    @Html.ActionLink("Startseite", "Index", "Collab")
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

    <div class="container">
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
            <div class="col-8">
                <h1 class="text-center">Mein Profil</h1>
                <div class="text-center">
                    @Html.ActionLink("Meine Jobanzeigen", "meineJobanzeigen", "Jobanzeige", Nothing, New With {.class = "btn btn-info", .role = "button"})
                </div>


                @*<div class="container">
                    <div class="row">*@
                        <!--<div class="col" style="width: 250px; height: 250px; margin: 1em 8em 0 1em;">
    <!-- Für Bild -->
                        @*<img src="../Bilder/Team.jpg" alt="https://unsplash.com/photos/DsquaRPU_tA?utm_source=unsplash&utm_medium=referral&utm_content=creditShareLink" class="imgMeinProfil" />*@
                        @*<div class="overlay">
            <a href="#" style="color: white">Ändern</a>
        </div>*@
                        <!--</div>-->
                        <!--<div class="col">
        <!-- Den Rest -->
                        <!--<p style="font-size:20px; font-weight:800; margin-top: 20px;">ID: 12345</p>
            </div>
        </div>
    </div>-->

                        <div>
                            <!--style="width: 100%; margin: 4em 0 2em 0;"-->
                            <form method="get" action="Registrieren.html" style="width:70%;">
                                <p>
                                    <label for="txtVorname" id="lblVorname"><b>Vorname:</b></label>
                                    <input id="InputLeiste" type="text" name="txtVorname" placeholder="Vorname des Influencers" required /> <!--disabled, wenn angemeldeter Benutzer = Unternehmer-->
                                </p>
                                <p>
                                    <label for="txtName" id="lblName"><b>Name:</b></label>
                                    <input id="InputLeiste" type="text" name="txtName" placeholder="Name des Influencers" required /> <!--disabled, wenn angemeldeter Benutzer = Unternehmer-->
                                </p>
                                <p>
                                    <label for="txtFirmenname" id="lblFirmenname"><b>Firmenname:</b></label>
                                    <input id="InputLeiste" type="text" name="txtFirmenname" placeholder="Firmenname des Unternehmens" required /> <!--disabled, wenn angemeldeter Benutzer = Influencer-->
                                </p>
                                <p>
                                    <label for="txtProfilbeschreibung" id="lblProfilbeschreibung"><b>Profilbeschreibung:</b></label>
                                    <input id="InputLeiste" type="text" name="txtProfilbeschreibung" /> <!--placeholder="Profilbeschreibung max. 500 Wörter" size="500" style="height: 200px;" />--> <!-- Profilbeschreibung -->
                                </p>
                                <p>
                                    <label for="txtBenutzername" id="lblBenutzername"><b>Benutzername:</b></label>
                                    <input id="InputLeiste" type="text" name="txtBenutzername" placeholder="Benutzername" required />
                                </p>
                                <p>
                                    <label for="txtPasswort" id="lblPasswort"><b>Passwort:</b></label>
                                    <input id="InputLeiste" type="password" name="txtPasswort" placeholder="Passwort" required />
                                </p>
                                <p>
                                    <label for="txtEmail" id="lblEmail"><b>E-Mail:</b></label>
                                    <input id="InputLeiste" type="email" name="txtEmail" placeholder="E-Mail" required />
                                </p>
                                <p>
                                    <!--<label for="txtBranche" id="lblBranche"><b>Branche:</b></label>
                <input id="InputLeiste" type="text" name="txtBranche" placeholder="Branche" required />-->
                                    <label for="txtBranche" id="lblBranche"><b>Branche:</b></label>
                                    <select name="lstBranche"
                                            multiple="multiple" size="5" id="InputLeiste">
                                        <option value="1">Anime</option>
                                        <option value="2">Autos & Fahrzeuge</option>
                                        <option value="3">Beauty & Fashion</option>
                                        <option value="4">Bildung</option>
                                        <option value="5">DIY</option>
                                        <option value="6">Ernährung</option>
                                        <option value="7">Lifestyle</option>
                                        <option value="8">Gesundheit</option>
                                        <option value="9">Menschen & Blogs</option>
                                        <option value="10">Reisen & Events</option>
                                        <option value="11">Kunst & Design</option>
                                        <option value="12">Finanzen</option>
                                        <option value="13">Sonstiges</option>
                                    </select>
                                </p>

                                <div class="center" style="margin-top: 2em;">
                                    <input type="submit" name="btnSpeichern" value="Speichern" class="button" /> <!--Navigationsmöglichkeit noch keine. Stand: 06.05.2021-->
                                    <input type="reset" class="button" value="Abbrechen" onclick="javascript: confirm('Möchten Sie wirklich abbrechen? Ihre Änderungen werden endgültig gelöscht.');" />
                                </div>
                            </form>
                        </div>
            </div>

            <!--</div>-->
            <!-- right Column-->
            <div class="col-2">
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

        <!-- FOOTER -->
        <div id="footer" class="text-center">
            <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
        </div>

        <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
</body>
</html>
