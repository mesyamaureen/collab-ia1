@ModelType collab_asp.InfluencerViewModel

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
                        @Html.ActionLink("Startseite", "Index", "Collab")
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

    <!-- Contents -->
    <!-- Left Column -->
    <div class="container-fluid" style="background-color:#FFCCBC;">
        <div class="row">
            <div class="col-2">
                <ul class="nav flex-column position-fixed float-start">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index", "Collab")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Influencer suchen", "Influencersuchen", "AlleInfluencer")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Unternehmen suchen", "Unternehmensuchen", "AlleUnternehmen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Jobanzeigen", "AlleJobanzeigen", "AlleJobanzeigen")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")
                    </li>
                    <li class="nav-item">
                        @Html.ActionLink("Impressum", "Impressum")
                    </li>
                </ul>
            </div>

            <!-- Middle Column -->
            <div class="col-md-8" style="background-color:#ECECEC;">
                <div class="container-fluid">
                    <div class="jumbotron">
                        <div class="text-center">
                            <h1 class="align-content-lg-end mb-lg-3">
                                @Html.DisplayFor(Function(m) m.Influencer.Vorname)
                                @Html.DisplayFor(Function(m) m.Influencer.Name)
                            </h1>
                            <h2 class="align-content-end mb-lg-3">
                                [at]
                                @Html.DisplayFor(Function(m) m.Influencer.Benutzername)
                            </h2>
                            <h3 class="align-content-end mb-lg-5"> <!-- Hier Bewertung in Form von Sternchen -->
                                Bewertung: 
                            </h3>
                        </div>
                    </div>
                </div>

                <div class="mt-lg-2">
                    <div>
                        <h4 class="text-center mb-lg-3">
                            Branche
                        </h4>
                        <p class="text-center mb-lg-5">
                            @Html.DisplayFor(Function(m) m.Influencer.Branche.BrancheTitel)
                        </p>
                    </div>

                    <div>
                        <h4 class="text-center mb-lg-3">
                            Profilbeschreibung
                        </h4>
                        <p class="text-center mb-lg-5">
                            @Html.DisplayFor(Function(m) m.Influencer.Beschreibung)
                        </p>
                    </div>

                    <div>
                        <h4 class="text-center mb-lg-3">
                            E-Mail
                        </h4>
                        <p class="text-center mb-lg-5">
                            @Html.DisplayFor(Function(m) m.Influencer.Email)
                        </p>
                    </div>
                </div>
            </div>
            <!-- Right Column -->
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
