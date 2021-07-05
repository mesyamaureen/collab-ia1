﻿@ModelType collab_asp.Jobanzeige

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Bearbeiten</title>
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
        <div id="primaryContent">
            <h1 class="center">Jobanzeige</h1>
            <div id="primaryContentBlock" class="parallax">
                <div style="display:flex; flex-direction: column; justify-content: center; align-items: center; margin: 2em 0 2em 0;">
                    <!--style="width: 100%; margin: 4em 0 2em 0;"-->

                    @Using Html.BeginForm
                        @<div>
                            @Html.LabelFor(Function(m) m.Jobanzeige.Id)
                            @Html.TextBoxFor(Function(m) m.Jobanzeige.Id, New With {.readonly = "readonly"})
                            @Html.ValidationMessageFor(Function(m) m.Jobanzeige.Id)
                        </div>


                    End Using

                    <form method="post" action="MeineJobanzeigen.html" style="width:70%;">
                        <!-- bitte method und action hier aufpassen -->
                        <p>
                            <label for="txtTitel" id="lblTitel"><b>Titel:</b></label>
                            <input id="InputLeiste" type="text" name="txtTitel" placeholder="Titel der Jobanzeige" required /> <!--disabled, wenn angemeldeter Benutzer = Unternehmer-->
                        </p>
                        <p>
                            <label for="txtBranche" id="lblBranche"><b>Branche:</b></label>
                            <select name="lstBranche"
                                    multiple="multiple" size="5" id="InputLeiste">
                                <option value="1"> Anime</option>
                                <option value="2"> Autos & Fahrzeuge</option>
                                <option value="3"> Beauty & Fashion</option>
                                <option value="4"> Bildung</option>
                                <option value="5"> DIY</option>
                                <option value="6"> Ernährung</option>
                                <option value="7"> Lifestyle</option>
                                <option value="8"> Gesundheit</option>
                                <option value="9"> Menschen & Blogs</option>
                                <option value="10"> Reisen & Events</option>
                                <option value="11"> Kunst & Design</option>
                                <option value="12"> Finanzen</option>
                                <option value="13"> Sonstiges</option>
                            </select>
                        </p>
                        <p>
                            <label for="txtBeschreibung" id="lblBeschreibung"><b>Beschreibung:</b></label>
                            <input id="InputLeiste" type="text" name="txtBeschreibung" placeholder="Beschreibung" size="500" style="height: 200px;" required /> <!--disabled, wenn angemeldeter Benutzer = Influencer-->
                        </p>

                        <div Class="center" style="margin-top: 2em;">
                            <input type="submit" name="btnSpeichern" value="Speichern" Class="button" /> <!--Navigationsmöglichkeit noch keine. Stand: 06.05.2021-->
                            <input type="reset" Class="button" value="Abbrechen" onclick="javascript: confirm('Möchten Sie wirklich abbrechen? Ihre Änderungen werden endgültig gelöscht.');" />
                        </div>
                    </form>
                </div>
            </div>
        </div>


        <div id="footer">
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

        <!-- FOOTER -->
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>
</body>
</html>