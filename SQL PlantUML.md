@startuml
entity "U�ytkownicy" {
  + ID_Uzytkownika (PK, INT, AutoIncrement)
  Login (VARCHAR)
  Haslo (VARCHAR, zaszyfrowane)
  Email (VARCHAR)
  Rola (VARCHAR)
}

entity "Quizy" {
  + ID_Quizu (PK, INT, AutoIncrement)
  ID_Tworcy (FK, U�ytkownicy.ID_Uzytkownika)
  LiczbaPytan (INT)
  DataUtworzenia (DATETIME)
}

entity "Pytania" {
  + ID_Pytania (PK, INT, AutoIncrement)
  ID_Quizu (FK, Quizy.ID_Quizu)
  Tresc (TEXT)
}

entity "Odpowiedzi" {
  + ID_Odpowiedzi (PK, INT, AutoIncrement)
  ID_Pytania (FK, Pytania.ID_Pytania)
  Tresc (VARCHAR)
  Poprawna (BOOL)
}

entity "Wyniki" {
  + ID_Wyniku (PK, INT, AutoIncrement)
  ID_Uzytkownika (FK, U�ytkownicy.ID_Uzytkownika)
  ID_Quizu (FK, Quizy.ID_Quizu)
  Wynik (INT)
  DataRozwiazania (DATETIME)
}

entity "Uprawnienia" {
  + ID_Uprawnienia (PK, INT, AutoIncrement)
  Rodzaj (VARCHAR)
}

U�ytkownicy }-- Uprawnienia : Posiada

U�ytkownicy --{ Quizy : Tworzy
Quizy }-- Pytania : Zawiera
Pytania }-- Odpowiedzi : Zawiera
Wyniki }-- U�ytkownicy : Przypisane do
Wyniki }-- Quizy : Zwi�zane z
@enduml
