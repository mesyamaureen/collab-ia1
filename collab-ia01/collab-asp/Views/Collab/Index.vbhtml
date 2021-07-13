
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
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Collab</title>
</head>
<body>
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
                        @Html.ActionLink("Influencer suchen", "Influencersuchen", "AlleInfluencer")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Unternehmen suchen", "Unternehmensuchen", "AlleUnternehmen")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Registrieren", "Registrieren", "Registrieren")
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <div class="container-fluid" style="background-color:#FFCCBC;">
        <!-- left Column -->
        <div class="row">
            <div class="col-2">
                <ul class="nav flex-column position-fixed float-start">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Influencer suchen", "Influencersuchen", "AlleInfluencer")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Unternehmen suchen", "Unternehmensuchen", "AlleUnternehmen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Impressum", "Impressum")
                    </li>
                </ul>
            </div>


            <!-- middle Column -->
            <div class="col-md-8" style="background-color:#ECECEC;">
                <div class="text-center" style="margin-bottom: 40px;">
                    <div class="w-100">
                        <img src="../Bilder/Startseite.jpg" id="image" height="400" alt="https://unsplash.com/photos/yyMJNPgQ-X8?utm_source=unsplash&utm_medium=referral&utm_content=creditShareLink" />
                    </div>
                    <div class="text-center" style="margin: 20px 0 30px 0;">
                        <h1 class="center" style="margin-bottom:30px;">All-In-One Lösung für Alle im Influencer-Marketing</h1>
                        <h2 class="center">Übersichtliche Überblick, vielfältige Auswahlen, Kosten- und Zeitersparnis</h2>
                    </div>
                    <div class="text-center">
                        @Html.ActionLink("Influencer suchen", "Influencersuchen", "AlleInfluencer", Nothing, New With {.class = "btn btn-info", .role = "button"})
                        @Html.ActionLink("Unternehmen suchen", "Unternehmensuchen", "AlleUnternehmen", Nothing, New With {.class = "btn btn-info", .role = "button"})
                    </div>
                </div>

                <div class="text-center" style="margin: 10px 0 50px 0;">
                    <h2 class="center">Was bieten wir an?</h2>
                    <p class="center">Wir bieten ein Plattform zur Vermittlung von Influencern zu den passenden Unternehmen an. <br /> Wir helfen Ihnen, Ihre Planungsphase beim Influencer-Kampagne zu verkürzen.</p>
                </div>

                <!-- Meet The Team -->
                <div class="text-center" style="margin-bottom: 20px;">
                    <h2>Lernen Sie unser Team kennen!</h2>
                </div>
                <div class="container" style="margin: 20px 0 50px 0;">
                    <div class="row">
                        <!-- Clara Scherf -->
                        <div class="col">
                            <div class="card">
                                <img src="../Bilder/ClaraScherf.jpeg" alt="Clara Scherf" style="width:100%" />
                                <div class="container">
                                    <h3 class="center">Clara Scherf</h3>
                                    <p class="title">IT</p>
                                </div>
                            </div>
                        </div>
                        <!-- Mesya Jeynie -->
                        <div class="col">
                            <div class="card">
                                <img src="../Bilder/MesyaJeynie.jpeg" alt="Mesya Jeynie" style="width:100%" />
                                <div class="container">
                                    <h3 class="center">Mesya Jeynie</h3>
                                    <p class="title">IT</p>
                                </div>
                            </div>
                        </div>
                        <!-- Nina Hochtritt -->
                        <div class="col">
                            <div class="card">
                                <img src="../Bilder/NinaHochtritt.jpeg" alt="Nina Hochtritt" style="width:100%" />
                                <div class="container">
                                    <h3 class="center">Nina Hochtritt</h3>
                                    <p class="title">IT</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

                <!-- right Column-->
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
    <!-- FOOTER -->
    <div class="text-center mt-lg-5">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>

    <!-- Bootstrap -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
</body>
</html>
