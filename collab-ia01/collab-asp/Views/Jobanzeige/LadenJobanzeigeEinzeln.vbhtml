﻿
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    @*<meta name="viewport" content="width=device-width" />
        <title>LadenJobanzeigeEinzeln</title>*@
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>collab - Influencer Marketing Tool</title>
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800&display=swap" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../Css/collab.css" />
</head>
<body>
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
                    <a href="Startseite.html" accesskey="1" title="Startseite">Startseite</a>
                </li>
                <li>
                    <a href="Influencer suchen.html" accesskey="2" title="Influencer suchen">Influencer suchen</a>
                </li>
                <li>
                    <a href="Unternehmen suchen.html" accesskey="3" title="Unternehmen suchen">Unternehmen suchen</a>
                </li>
                <li>
                    <a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen">Jobanzeigen</a>
                </li>
                <li>
                    <a href="Einloggen.html" accesskey="5" title="Einloggen">Einloggen</a>
                </li>
                <li>
                    <a href="Registrieren.html" accesskey="6" title="Registrieren">Registrieren</a>
                </li>
            </ul>
        </div>
    </div>
    <div id="body">
        <!-- Content fängt hier an -->
        <!-- left Column -->
        <div id="secondaryContentContainer">
            <div id="secondaryContent">
                <ul style="font-size:16px;">
                    <li id="current">
                        <a href="Startseite.html">Startseite</a>
                    </li>
                    <li>
                        <a href="Influencer suchen.html">Influencer suchen</a>
                    </li>
                    <li>
                        <a href="Unternehmen suchen.html">Unternehmen suchen</a>
                    </li>
                    <li>
                        <a href="Jobanzeigen.html">Jobanzeigen</a>
                    </li>
                    <li>
                        <a href="Einloggen.html">Einloggen</a>
                    </li>
                    <li>
                        <a href="Impressum.html">Impressum</a>
                    </li>
                </ul>
            </div>
        </div>

        <!-- middle Column -->
        <div id="primaryContent">
            <!-- bis hier -->
            <div class="parallax">
                <h1 class="center">Mehr über die Jobanzeige</h1>
                <h2 class="center">Passt der Job für mich?</h2>
            </div>
            <div id="primaryContentBlock">
                <h3 style="font-weight:800;">#LidlStudio - Lidl sucht Influencer!</h3>
                <div>
                    <h4><i>Beschreibung</i></h4>
                    <div>
                        <p>
                            Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.

                            Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.

                            Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.

                            Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.

                            Duis autem vel eum iriure
                        </p>
                    </div>
                </div>

                <div style="margin-top: 5em;">
                    <h4><i>Bauen Sie Kontakt mit dem Unternehmen ab!</i></h4>
                    <div>
                        <form method="get" action="MeineJobanzeigen.html">
                            <!-- Neu erstellte Bewerbung-->
                            <!-- Enable: nur von einem angemeldeten Benutzer. Sonst disabled -->
                            <p>
                                Betreff:
                                <input type="text" name="txtBetreff" id="InputLeiste" placeholder="Ihr Betreff" />
                            </p>
                            <p>
                                Nachricht:
                                <textarea id="nachricht" name="nachricht" placeholder="Ihre Nachricht..." style="width: 100%; height: 100%;"></textarea>
                            </p>

                            <div class="right" style="margin: 15px 0 40px 0;">
                                <input type="submit" name="btnAbschicken" value="Abschicken" class="button" /> <!--Navigationsmöglichkeit noch keine. Stand: 06.05.2021-->
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>


        <!-- right Column-->
        <div id="tertiaryContent">
            <fieldset id="fldKontakt">
                <legend style="font-weight:600;">Brauchen Sie Hilfe?</legend>
                <p>Tel.: 030 38 99 00</p>
                <p>E-Mail: collab@info.de</p>
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
