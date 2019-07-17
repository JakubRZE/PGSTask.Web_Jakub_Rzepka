# PGSTask.Web_Jakub_Rzepka
ASP.NET Core 2.1 application

Aplikacja pozwalająca użytkownikowi na tworzenie prostej listy zadań. Każde zadanie musi mieć opis.
Zadania dodane do listy mogą zostać edytowane (ikonka edycji -> wpisanie docelowej wartości -> zatwierdzenie zmian zieloną ikonką),
lub usuniętę (ikonka kosza).

Lista zadań wyposażona jest w paginację, sortowanie według kolumn ( poprzez kliknięcie - Description lub Created at w table header), 
oraz filtrowanie poprzez wprowadzene pożadanej watosci do okienka wyszukiwania.

Wprowadzone wartości sprawdzane pod po strownie klienta i servera pod wzgledem poprawnosci.
