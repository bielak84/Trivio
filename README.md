//Projekt SQL

@startuml
entity "Użytkownicy" {
  + ID_Uzytkownika (PK, INT, AutoIncrement)
  Login (VARCHAR)
  Haslo (VARCHAR, zaszyfrowane)
  Email (VARCHAR)
  Rola (VARCHAR)
}

entity "Quizy" {
  + ID_Quizu (PK, INT, AutoIncrement)
  ID_Tworcy (FK, Użytkownicy.ID_Uzytkownika)
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
  ID_Uzytkownika (FK, Użytkownicy.ID_Uzytkownika)
  ID_Quizu (FK, Quizy.ID_Quizu)
  Wynik (INT)
  DataRozwiazania (DATETIME)
}

Użytkownicy --{ Quizy : Tworzy
Quizy }-- Pytania : Zawiera
Pytania }-- Odpowiedzi : Zawiera
Wyniki }-- Użytkownicy : Przypisane do
Wyniki }-- Quizy : Związane z
@enduml
//

