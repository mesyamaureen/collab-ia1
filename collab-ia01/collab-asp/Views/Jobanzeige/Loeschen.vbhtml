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
