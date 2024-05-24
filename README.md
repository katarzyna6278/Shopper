# Notatki z zajęć

Odpalenie terminala - w lupce na np windowsie wpisz `cmd` lub `wiersz poleceń` lub `command prompt` 
Żeby przenieść się do danego folderu użyj komendy `cd` <ścieżka do folderu> na przykład `cd C:\CyberTrainees\Shopper`

Sprawdzanie statusu

git status

##Tworzenie nowego brancha 
`git switch main` 
`git checkout -b "imie"` 
`git status `
`git push` 
`git push --set-upstream origin "nazwa tego brancha"` 
`git status `


##Dodawanie nieśledzonych plików do śledzenia  na github 
`git add .` 

##Tworzenie commita
`git commit -m "Tutaj wpisz swoją wiadomość, co jest w commicie, co commit robi"` 

##Wysyłanie commita na githuba 
`git push` 

##-- Ewentualnie wysłanie commita na githuba jeśli jest to nowy branch 
`git push --set-upstream origin "nazwa tego brancha"` 

## Przełączanie się po branchach/gałęziach
`git switch "nazwa brancha"`

## Wylistowanie dostępnych branchy na remote(github.com)
`git branch -r` 

## Wylistowanie branchy dostępnych lokalnie (te na które się przełączaliśmy lub sami stworzyliśmy)
`git branch`

## Zresetowanie brancha, żeby był taki sam jak main na githubie:
`git add .` - git będzie obserwował wszystkie zmiany na branchu,
`git stash` - schowaj zmiany na aktualnym branchu do "szufladki", 
`git fetch` - sprawdź czy istnieją zmiany na githubie/ na remote (wciągasz dane na brancha na któyrym jesteś i sprawdzasz czy inne branche posiadają zmiany do wciągnięcia), 
`git switch main` - przełączenie na maina, 
`git pull` - wciągnij zmiany z remote na main (wciągasz tylko i wyłacznie dane na brancha na którym jesteś), 
`git switch <twój branch>` - przenieś się na inny branch, 
`git reset --hard origin/main` - zresetuj swój branch żeby był 1:1 do main, 
`git push -f`  - wypchnij zmiany "na siłę" (-f)

## Wylistowanie ostatnich commitów
`git log` - wylistowanie commitów, 
Enter - listowanie dalszych commitów
`q` - wyjście z listy commitów



