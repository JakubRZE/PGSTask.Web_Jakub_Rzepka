# PGSTask.Web_Jakub_Rzepka
ASP.NET Core 2.1 application
<br />

Aplikacja pozwalająca użytkownikowi na tworzenie prostej listy zadań. Każde zadanie musi posiadać opis.
Zadania dodane do listy mogą zostać edytowane (ikonka edycji -> wpisanie docelowej wartości -> zatwierdzenie zmian zieloną ikonką),
lub usuniętę (ikonka kosza).

Lista zadań wyposażona jest w paginację, sortowanie według kolumn ( poprzez kliknięcie - Description lub Created_at w table header), 
oraz filtrowanie poprzez wprowadzene pożadanej watosci do okienka wyszukiwania.

Wprowadzone wartości są sprawdzane po strownie klienta i servera pod wzgledem poprawnosci(opis zadania nie może być pusty).

<h4>Aplikacja jest możliwa do uruchomienia poprzez Visual Studio,<br />
lub znajduje się na serwerze Azure pod adresem:

https://usertasklist.azurewebsites.net</h4>

<br /><br />
Screenshot[1]:
![tasklist](https://user-images.githubusercontent.com/38703432/61385532-da340c80-a8b2-11e9-90d0-e011c02fd138.png)



