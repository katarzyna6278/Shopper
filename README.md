# Notatki z zajęć
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

## Zresetowania brancha, żeby był taki sam jak main na githubie:
git reset --hard origin/main


