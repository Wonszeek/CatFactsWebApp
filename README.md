Prosta aplikacja webowa w ASP.NET Core Razor Pages, która pobiera losowe fakty o kotach z publicznego API i zapisuje je do lokalnego pliku tekstowego.

## Technologie
- ASP.NET Core 8 (Razor Pages)
- C#
- Dependency Injection (DI)
- HttpClient, File I/O
- HTML + Razor syntax

## Funkcjonalności
- Pobieranie losowego faktu o kotach z API https://catfact.ninja/fact
- Zapisywanie każdego faktu do lokalnego pliku catfacts.txt
- Wyświetlanie historii zapisanych faktów na stronie
- Obsługa dwóch przycisków: "Pobierz nowy fakt" oraz "Pokaż historię"

## Struktura projektu
- Pages/Index.cshtml – widok z formularzami
- Pages/Index.cshtml.cs – logika dla przycisków
- Services/ICatFactService.cs – interfejs do pobierania danych z API
- Services/CatFactService.cs – implementacja API clienta
- Services/IFileWriterService.cs – interfejs do operacji na pliku
- Services/FileWriterService.cs – zapis i odczyt danych z pliku
- Program.cs – rejestracja serwisów w DI
