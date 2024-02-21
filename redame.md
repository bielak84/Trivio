//Projekt SQL

@startuml

entity "U�ytkownicy" {
  + ID_Uzytkownika (PK, INT, AutoIncrement)
  Login (VARCHAR)
  Haslo (VARCHAR, zaszyfrowane)
  Email (VARCHAR)
  Rola (VARCHAR)
}

entity "KategorieQuizow" {
  + ID_Kategorii (PK, INT, AutoIncrement)
  NazwaKategorii (VARCHAR)
}

entity "PoziomyTrudnosci" {
  + ID_Poziomu (PK, INT, AutoIncrement)
  NazwaPoziomu (VARCHAR)
}

entity "Quizy" {
  + ID_Quizu (PK, INT, AutoIncrement)
  ID_Tworcy (FK, U�ytkownicy.ID_Uzytkownika)
  ID_Kategorii (FK, KategorieQuizow.ID_Kategorii)
  ID_Poziomu (FK, PoziomyTrudnosci.ID_Poziomu)
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

U�ytkownicy --{ Quizy : Tworzy
Quizy }-- KategorieQuizow : Nale�y do
Quizy }-- PoziomyTrudnosci : Poziom trudno�ci
Pytania }-- Quizy : Zawiera
Odpowiedzi }-- Pytania : Zawiera
Wyniki }-- U�ytkownicy : Przypisane do
Wyniki }-- Quizy : Zwi�zane z

@enduml
//

