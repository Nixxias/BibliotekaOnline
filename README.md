
## 📚 System Zarządzania Biblioteką 

I do not permit any commercial use, editing, or using the code as your own for commercial purposes. Any use, either personal or commercial, without prior contact and explicit permission is strictly prohibited. Please contact me before using the code for any purpose to obtain consent.

## 📌 Opis projektu

Jest to aplikacja webowa stworzona w języku C# w ramach technologii .NET 6.0. Projekt umożliwia zarządzanie biblioteką poprzez funkcjonalności takie jak przeglądanie książek, zarządzanie wypożyczeniami oraz administrację użytkownikami. Interfejs użytkownika zawiera elementy HTML, JavaScript oraz CSS, a baza danych wykorzystuje PostgreSQL.

## ⚠️ Licencja i zasady użytkowania

❌ Zabronione działania:

Komercyjne wykorzystanie kodu bez zgody autora.

Edytowanie i używanie kodu jako własnego w celach komercyjnych.

Jakiekolwiek wykorzystanie kodu bez wcześniejszego kontaktu i wyraźnej zgody.

🔒 Aby uzyskać pozwolenie na użycie kodu, skontaktuj się ze mną przed jego wykorzystaniem.

## 🛠 Instalacja i konfiguracja

## 1️⃣ Pobranie projektu

Rozpakuj plik "Biblioteka Projekt wszystko w jednym.zip" i umieść rozpakowany folder w lokalizacji projektów Visual Studio 2022.

Jeśli nie znasz tej lokalizacji, uruchom Visual Studio 2022 i utwórz nowy projekt – w ten sposób znajdziesz odpowiednią ścieżkę.

## 2️⃣ Konfiguracja bazy danych

Uruchom pgAdmin 4 (z zainstalowanym PostgreSQL 17).

Utwórz bazę danych o nazwie Biblioteka.

Skopiuj zawartość pliku Baza.txt do Query Tool (Alt+Shift+Q) i uruchom (F5), aby utworzyć tabele.

## 3️⃣ Sprawdzenie połączenia z bazą

Upewnij się, że baza Biblioteka posiada następujące dane serwera:

Host: localhost

Port: 5432

Użytkownik: postgres

Hasło: postgres

Jeśli posiadasz inne dane, zmień je w pgAdmin 4 lub w pliku appsettings.json w projekcie.

## 4️⃣ Uruchomienie projektu

Otwórz plik TEST.sln w Visual Studio 2022.

Uruchom projekt w trybie debugowania – zalecana przeglądarka: Microsoft Edge.

Przy pierwszym uruchomieniu zaakceptuj certyfikat SSL.

## 5️⃣ Wymagane pakiety Visual Studio 2022

Ważne jest aby w pakietach Visual Studio 2022 Installer mieć zainstalowane : "Opracowywanie zawartości dla platformy ASP.Net ..." z Sieć Web i Chmura oraz z Komputery i urządzenia przenośne "Programowanie aplikacji klasycznych dla platformy .Net"

## 🔑 Dane testowe do logowania

Rola

Login

Hasło

Czytelnik

jan.kowalski

password123

Bibliotekarz

pwisniewski

haslo789

Administrator

admin

zaq1@WSX

# 📋 Funkcjonalności

## 👤 Interfejs Czytelnika

✔️ Przeglądanie książek (wyszukiwanie, sortowanie, filtrowanie).
✔️ Podgląd swoich wypożyczeń (termin zwrotu, status zwrotu).
✔️ Edycja danych konta.

## 📖 Interfejs Bibliotekarza

✔️ Przeglądanie książek (wyszukiwanie, sortowanie, filtrowanie).
✔️ Dodawanie nowych książek i ich kopii.
✔️ Przeglądanie listy czytelników i ich danych kontaktowych.
✔️ Zarządzanie wypożyczeniami (dodawanie nowych wypożyczeń, rejestracja zwrotów).

## 🛠 Interfejs Administratora

✔️ Pełne zarządzanie książkami (dodawanie, edycja, usuwanie).
✔️ Edycja, dodawanie i usuwanie wpisów w bazie danych (Autorzy, Czytelnicy, Gatunki, Oddziały, Regały, Wypożyczenia itp.).

## 🖼 Zrzuty ekranu

Tutaj zostanie wrzucony gif z funkcjonalnością strony :) 

## 📩 Kontakt

Jeśli masz pytania dotyczące projektu, skontaktuj się ze mną przed jego użyciem.

📌 Projekt inspirowany funkcjonalnością rzeczywistej biblioteki – umożliwia zarządzanie danymi, przeglądanie dostępnych książek i zarządzanie wypożyczeniami. 📌
