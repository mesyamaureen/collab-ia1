@ModelType collab_asp.Jobanzeige

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
    <title>Loeschen</title>
</head>
<body>
    <!-- Header -->
    @*<div>*@
    @*<div id="header">
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
    @*</li>
        <li>
            @Html.ActionLink("Unternehmen suchen", "UnternehmenSuchen", "AlleUnternehmen")
            @*<a href="Unternehmen suchen.html" accesskey="3" title="Unternehmen suchen" style="color: black">Unternehmen suchen</a>*@
    @*</li>
        <li>
            @Html.ActionLink("Jobanzeigen", "Jobanzeigen", "AlleJobanzeigen")*@
    @*<a href="Jobanzeigen.html" accesskey="4" title="Jobanzeigen" style="color: black">Jobanzeigen</a>*@
    @*</li>
        <li>
            @Html.ActionLink("Einloggen", "Einloggen", "AlleProfile")*@
    @*<a href="Einloggen.html" accesskey="5" title="Einloggen" style="color: black">Einloggen</a>*@
    @*</li>
        <li>
            @Html.ActionLink("Registrieren", "Registrieren")*@
    @*<a href="Registrieren.html" accesskey="6" title="Registrieren" style="color: black">Registrieren</a>*@
    @*</li>
                </ul>
            </div>
        </div>*@

    @*<div>
            <h1>Aufgabe "@Model.Titel" löschen</h1>
            <p>Möchten Sie die Jobanzeige "@Model.Titel" wirklich löschen?</p>

            @Using Html.BeginForm
                @<div>
                    <!-- Verstecktes Feld für die ID der zu löschenden Aufgabe -->
                    @Html.HiddenFor(Function(m) Model.JobID)
                </div>
                @<div>
                    <!-- Link zum Abbrechen, d.h. zur Navigation zur Index-Seite und Schaltfläche zum Absenden des Formulars -->
                    @Html.ActionLink("Abbrechen", "Index")
                    <input type="submit" value="Löschen" />
                </div>
            End Using

        </div>*@




        @*<!-- middle Column -->
        <div id="primaryContent">
            <h1 class="center">Jobanzeige</h1>
            <div id="primaryContentBlock" class="parallax">
                <div style="display:flex; flex-direction: column; justify-content: center; align-items: center; margin: 2em 0 2em 0;">
                    <!--style="width: 100%; margin: 4em 0 2em 0;"-->

                    @Using Html.BeginForm
                        @<div class="form-group row">
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
                            @Html.DropDownListFor(Function(m) Model.Jobanzeige.Branche.BrancheID, New SelectList(Model.ListeBranche, "BrancheID", "BrancheTitel"), New With {.class = "form-control"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.Branche.BrancheTitel)
                        </div>

                        @<div class="form-group">
                            @Html.LabelFor(Function(m) m.Jobanzeige.UnternehmerID, New With {.readonly = "readonly", .hidden = "true"})*@
                            @*@Html.HiddenFor(Function(m) m.Jobanzeige.UnternehmerID, New With {.readonly = "readonly"})
                            @Html.ValidationMessageFor(Function(m) Model.Jobanzeige.UnternehmerID)*@
                        @*</div>

                        @<div>
                            @Html.ActionLink("Abbrechen", "meineJobanzeigen", Nothing, New With {.class = "btn btn-default", .role = "button"})
                            <input type="submit" class="btn btn-primary" value="Speichern" />
                        </div>
                    End Using*@
                @*</div>
            </div>
        </div>*@

        <div id="dlgWirklich" class="modal fade" role="dialog">
            <div class="modal-dialog modal-lg modal-dialog-centered" role="document">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Jobanzeige "@Html.Encode(Model.Titel)" löschen</h4>
                        <button type="button" class="close" aria-label="Close">
                            @Html.ActionLink("x", "meineJobanzeigen", Nothing, New With {.class = "btn close"})
                        </button>
                    </div>

                    <div class="modal-body">
                        <p>Möchten Sie die Aufgabe "@Html.Encode(Model.Titel)" wirklich löschen?</p>
                    </div>

                    <div class="modal-footer">
                        @Using Html.BeginForm
                            @<div>
                                @Html.HiddenFor(Function(m) Model.JobID)
                            </div>
                            @<div>
                                @Html.ActionLink("Nein", "meineJobanzeigen", Nothing, New With {.class = "btn btn-secondary"})
                                <input type="submit" class="btn btn-danger " value="Löschen" />
                            </div>
                        End Using

                    </div>
                </div>

            </div>

        </div>


    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>

    <!-- Dialog öffnen, nachdem JavaScript-Dateien geladen wurden -->
    <script type="text/javascript">
        $("#dlgWirklich").modal("show");
    </script>
</body>
</html>
