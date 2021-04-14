# kampfsportverein
Verwaltung von Kampfsportverein DBS2

## How to setup git repo in local computer:
### Prepare repository folder
1) Erstell einen Ordner auf deinem Rechner unter `name_datenbanksystem02`(z.B. meins auf dem Desktop unter 'mesya_datenbanksystem02')
2) Doppelklick auf dem Ordner
### Configure Email and Username for Github
3) Rechtsklick irgendwo innerhalb des Ordners
4) Klick `Git Bash Here`
5) The Command Line Interface (CLI) sollte angezeigt werden (Drauf sollte MINGW64 geschrieben werden) 
6) Tip direkt nach dem $ Zeichen `git config --global user.email "`*deine E-Mail für Github*`"` und ENTER 
7) Eine neue Zeile sollte angezeigt werden
8) Tip direkt nach dem $ Zeichen auf der neuen Zeile `git config --global user.name "`*dein username*`"` und ENTER 
### Configuring SSH Key for Github account
9) Jetzt fügen wir einen Public SSH Schlüssel zu deinem Github Konto hinzu
10) Tip direkt nach dem $ Zeichen auf der neuen Zeile `ssh-keygen` und ENTER 
11) Sollte gefragt werden, die zu speichernde Dateien einzugeben, tip bitte nichts ein und einfach ENTER
12) Sollte gefragt werden, Passwort einzugeben, tip bitte nichts ein und einfach ENTER
13) Der Schlüssel wird erzeugt. Mach nur weiter, wenn eine neue Zeile (wo $ Zeichen zu sehen ist) verfügbar ist.
14) Um den SSH Schlüssel von deinem Laptop mit deinem Github Konto zu verbinden, musst du zuerst den Inhalt der `.pub` Datei kopieren.
15) To do so, tip GENAUSO `cat ~/.ssh/id_rsa.pub` auf der neuen Zeile
16) Die Rückmeldung sollte mit `ssh-rsa` anfangen. Das ist deinen public SSH Key.
17) Kopierst alle von `ssh-rsa` bis Ende des Random Schlüssels (vor dem Leerzeichen und dem Name deines Laptops)
18) Geh zurück zu der Github Webseite und geh zu der Einstellung (oben rechts) deines Github Kontos
19) Klick auf `SSH and GPG Keys` (linke Seite)
20) Klick auf `New SSH Key`
21) Tip irgendwelchen Namen für den Titel (z.B. "Mesya's WindowsLaptop")
22) Dann fügst du den SSH Schlüssel innerhalb des Key Box ein und klick auf `Add SSH Key` ganz unten
23) Sollte alles gut gelaufen ist, wird ein neuer SSH Schlüssel auf deinem Github Konto gespeichert.
### Cloning the repository to your local computer
24) Geh zurück zu der Repository Page auf deiner Github Webseite
25) Klick auf `Clone or Download` Schaltfläche 
26) Achtung: Es muss `Clone with SSH`sein. Da gibt's einen Umschalter (oben rechts), von HTTPS zu SSH und vice versa zu tauschen.
27) Klick auf das Kopie Icon 
28) Geh zurück zu dem CLI auf deinem Laptop
29) Tip direkt nach dem $ Zeichen auf der neuen Zeile `git clone` ein und füg den Clone Link vom Github ein und ENTER
30) Das Git Repository sollte erfolgreich geklont werden. Zu überprüfen: Öffne mal den Ordner (Schritt 1) auf dem Windows Explorer. Da sollte es einen neuen Ordner unter dem Namen deines Repository innerhalb des Verzeichnis (Schritt 1) geben.
### Check whether or not the repository on your computer is up-to-date
31) Danach müssen wir zu dem `master` des Repository umziehen. Es gibt zwei Wege (Schritt 32 & 33).
32) The cooler CLI way: Tip auf der neuen Zeile (nach dem $ Zeichen) im Gitbash `cd kampfsportverein/` ein und ENTER. Danach solltest du der Wort `(master)`oder `(main)` direkt nach deinem directory line (MINGW64).
33) The simpler GUI way: double click the folder of the cloned repo in Windows Explorer and redo step 3 and 4
34) Tip im Gitbash `git status` ein, um deine Dateien zu überprüfen.
35) Whatever response you get from step 34, it is always a good practice to update your local folder with the one on Github, even though nothing might have changed (Do this before you do anything else) in which you type `git pull` 

## How to work with git
Any Visual Studio file related to this project should be saved inside the repository folder (datenbanksystem01)
### Cheatsheets
1) `git status` : To check any changes in the repository folder
2) `git pull` : To download the actual file or changes in Github
3) `git add --a` : To add all changes made in the repository folder that will be pushed to Github
4) `git commit -m "enter any message about the changes made"` : Only do this after number 3! To add valuable information about what was changed
5) `git push` : To upload all changes and information to Github

### Process
Please note that when you enter a new command, make sure that the CLI has done loading/processing (This can be known when the CLI has given you a new command line (the line where you can type onto after the $ sign))

1) Everytime you run the gitbash by right clicking inside the repository folder, enter the command `git status` to update if any changes are made
2) Then pull the changes by entering the command `git pull`
3) Then go to the repository folder in Windows Explorer and you should already find the updated file (in this case a Visual Studio Projektmappe *datenbanksystem01*)
4) After finishing your part, go to the CLI and run `git status`and `git pull` one more time to make sure that your file in Windows Explorer is the latest one. As long as we do our own part, we should never encounter any merge error.
5) Then enter the command `git add --a`
6) Then enter the command `git commit -m "enter any message about the changes made"`
7) Then enter the command `git push`
