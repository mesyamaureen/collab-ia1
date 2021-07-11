@ModelType collab_asp.Unternehmen

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Unternehmer</title>
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
                    @Html.ActionLink("Startseite", "Index", "Collab")
                </li>
                <li>
                    @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
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
                        @Html.ActionLink("Startseite", "Index", "Collab")
                    </li>
                    <li>
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
                    </li>
                    <li>
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen")
                    </li>
                    <li>
                        @Html.ActionLink("Jobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li>
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
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
            <div id="primaryContentBlock">
                <div id="meinProfilBild" class="parallax">
                    <div style="width:250px; height: 250px; margin: 0 8em 2em 1em;">
                        <img src="../Bilder/Team.jpg" alt="https://unsplash.com/photos/DsquaRPU_tA?utm_source=unsplash&utm_medium=referral&utm_content=creditShareLink" class="imgMeinProfil" style="margin-top: 25px;" />
                    </div>
                    <div class="buttonHalterMP">
                        <h1 class="left">Lidl</h1>
                        <h2 class="left">lidl_de</h2>
                        <div style="display:flex; flex-direction:row;">
                            <a href="#">Bewertung:</a>
                            <div style="display:flex; flex-direction: row; justify-content:flex-start; align-items:center;">
                                <span class="fa fa-star checked" style="margin-left:0;"></span>
                                <span class="fa fa-star checked" style="margin-left:0;"></span>
                                <span class="fa fa-star checked" style="margin-left:0;"></span>
                                <span class="fa fa-star checked" style="margin-left:0;"></span>
                                <span class="fa fa-star" style="margin-left:0;"></span>
                            </div>
                        </div>
                    </div>
                </div>

                <div style="display:flex; flex-direction: column; justify-content: center; align-items: center; margin: 2em 0 2em 0;">
                    <!--style="width: 100%; margin: 4em 0 2em 0;"-->
                    <h3 style="font-weight:600;">Branche:</h3>
                    <p>Lebensmitteleinzelhandel</p>
                    <div style="text-align: center;">
                        <h3 style="font-weight:600;">Profilbeschreibung:</h3>
                        <p>
                            Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.

                            Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet,
                        </p>
                    </div>
                    <h3 style="font-weight:600;">E-Mail:</h3>
                    <a href="mailto:lidl@info.de" style="font-size: small;">lidl@info.de</a>
                </div>


                <!--Chat Button -->
                <button class="open-button" onclick="openForm()">Chat</button>

                <div class="chat-popup" id="myForm">
                    <form action="/action_page.php" class="form-container">
                        <h1>Chat</h1>

                        <label for="msg"><b>Message</b></label>
                        <textarea placeholder="Type message.." name="msg" required></textarea>

                        <button type="submit" class="btn">Send</button>
                        <button type="button" class="btn cancel" onclick="closeForm()">Close</button>
                    </form>
                </div>

                <script>
                    function openForm() {
                        document.getElementById("myForm").style.display = "block";
                    }

                    function closeForm() {
                        document.getElementById("myForm").style.display = "none";
                    }
                </script>
                <!--until here-->
            </div>
        </div>


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
