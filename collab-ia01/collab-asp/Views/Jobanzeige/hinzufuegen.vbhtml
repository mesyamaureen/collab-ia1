@ModelType collab_asp.JobanzeigeViewModel

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
    <title>Hinzufuegen</title>
</head>
<body>
    <!-- Header -->
    <div>
        <div id="header" style="background-color: #ECECEC;">
            <a title="zur Startseite" href="Startseite.html">
                <img src="../Bilder/COLLAB-BILD.png" width="300" alt="Collab-Logo" />
            </a>
            <h1 style="font-style: italic;">Collaborate with the right influencer</h1>
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
    </div>

    <div class="container-fluid" style="background-color:#FFCCBC;">
        <!-- Content fängt hier an -->
        <!-- left Column -->
        <div class="row">
            <div class="col-2">
                <ul class="nav flex-column">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index", "Collab")
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
                    </li>
                </ul>
            </div>



            <!-- middle Column -->
            <div class="col-md-8" style="background-color:#ECECEC;">
                <div class="text-center">
                    <h1>Neue Jobanzeige hinzufügen</h1>
                    <p>Hier können Sie eine neue Jobanzeige hinzufuegen.</p>
                </div>

                <div class="w-100">
                    @Using Html.BeginForm()
                        @<div class="form-group">
                            <!-- Verstecktes Feld für die ID der Aufgabe, die dem Benutzer nicht angezeigt werden muss -->
                            @Html.HiddenFor(Function(m) Model.Jobanzeige.JobID)
                        </div>

                        @<div class="form-group">
                            @*@Html.LabelFor(Function(m) m.Jobanzeige.UnternehmerID, New With {.readonly = "readonly", .hidden = "true"})*@
                            @Html.HiddenFor(Function(m) m.Jobanzeige.UnternehmerID, New With {.readonly = "readonly"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.UnternehmerID)
                        </div>

                        @<div class="form-group">
                            <!-- Titel der Jobanzeige -->
                            @Html.LabelFor(Function(m) Model.Jobanzeige.Titel, New With {.class = "control-label"})
                            @Html.TextBoxFor(Function(m) Model.Jobanzeige.Titel, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Titel)
                        </div>
                        @<div class="form-group">
                            <!-- Beschreibung der Jobanzeige -->
                            @Html.LabelFor(Function(m) Model.Jobanzeige.Beschreibung, New With {.class = "control-label"})
                            @Html.TextAreaFor(Function(m) Model.Jobanzeige.Beschreibung, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Beschreibung)
                        </div>

                        @<div class="form-group">
                            <!-- Branche der Jobanzeige -->
                            @Html.LabelFor(Function(m) Model.Jobanzeige.Branche.BrancheTitel, New With {.class = "control-label"})
                            @Html.DropDownListFor(Function(m) Model.Jobanzeige.Branche.BrancheID, New SelectList(Model.ListeBranche, "BrancheID", "BrancheTitel"), New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Branche.BrancheTitel)
                        </div>
                        @<div>
                            <!-- Link zum Abbrechen, d.h. zur Navigation zur Index-Seite und Schaltfläche zum Absenden des Formulars -->
                            @Html.ActionLink("Abbrechen", "meineJobanzeigen", Nothing, New With {.class = "btn btn-default", .role = "button"})
                            <input type="submit" class="btn btn-success" value="Erstellen" />
                        </div>
                    End Using
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
    </div>

    <!-- FOOTER -->
    <div class="text-center">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>
</body>
</html>
