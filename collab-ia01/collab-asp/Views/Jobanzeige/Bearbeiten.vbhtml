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
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" 
          integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" 
          crossorigin="anonymous">
    <title>Bearbeiten</title>
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
                <ul class="nav justify-content-end">
                    <li class="nav-item">
                        @Html.ActionLink("Startseite", "Index", "Collab")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Influencer suchen", "InfluencerSuchen", "AlleInfluencer")
                    </li>
                    <li class="nav-item" style="margin-left: 25px;">
                        @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen", "AlleUnternehmen")
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
    <!-- Content fängt hier an -->
    <div class="container-fluid" style="background-color:#FFCCBC;">
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
                <h1 class="text-center">Jobanzeige</h1>
                <p class="text-center">Jobanzeigen bearbeiten</p>
                <div class="w-100">
                    @Using Html.BeginForm
                        @<div class="form-group">
                            @Html.LabelFor(Function(m) m.Jobanzeige.JobID)
                            @Html.TextBoxFor(Function(m) m.Jobanzeige.JobID, New With {.readonly = "readonly", .class = "form-control-plaintext"})
                            @Html.ValidationMessageFor(Function(m) m.Jobanzeige.JobID)
                        </div>

                        @<div class="form-group">
                            @Html.LabelFor(Function(m) Model.Jobanzeige.Titel, New With {.class = "control-label"})
                            @Html.TextBoxFor(Function(m) Model.Jobanzeige.Titel, New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Titel)
                        </div>

                        @<div class="row">
                            <div class="col-sm-12">
                                <div class="form-group">
                                    @Html.LabelFor(Function(m) m.Jobanzeige.Beschreibung, New With {.class = "control-label"})
                                    @Html.TextBoxFor(Function(m) m.Jobanzeige.Beschreibung, New With {.class = "form-control"})
                                    @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Beschreibung)
                                </div>
                            </div>
                        </div>

                        @<div class="form-group">
                            @Html.LabelFor(Function(m) Model.Jobanzeige.Branche.BrancheTitel, New With {.class = "control-label"})
                            @Html.DropDownListFor(Function(m) Model.Jobanzeige.Branche.BrancheID,
                                           New SelectList(Model.ListeBranche, "BrancheID", "BrancheTitel"),
                                           New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Branche.BrancheTitel)
                        </div>

                        @<div class="form-group">
                            @Html.HiddenFor(Function(m) m.Jobanzeige.UnternehmerID, New With {.readonly = "readonly"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.UnternehmerID)
                        </div>

                        @<div class="mb-5">
                            @Html.ActionLink("Abbrechen", "meineJobanzeigen", Nothing,
                                      New With {.class = "btn btn-default", .role = "button"})
                            <input type="submit" class="btn btn-primary" value="Speichern" />
                        </div>
                    End Using
                </div>
            </div>

            <!--</div>-->
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
    <div class="text-center mt-lg-5">
        <p>Copyright © SS2021 Hochtritt, Jeynie, Scherf, BHT Berlin</p>
    </div>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" 
            integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" 
            crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" 
            integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" 
            crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" 
            integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" 
            crossorigin="anonymous"></script>
</body>
</html>
