//Projekt SQL

@startuml

entity "U퓓tkownicy" {
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
  ID_Tworcy (FK, U퓓tkownicy.ID_Uzytkownika)
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
  ID_Uzytkownika (FK, U퓓tkownicy.ID_Uzytkownika)
  ID_Quizu (FK, Quizy.ID_Quizu)
  Wynik (INT)
  DataRozwiazania (DATETIME)
}

U퓓tkownicy --{ Quizy : Tworzy
Quizy }-- KategorieQuizow : Nale퓓 do
Quizy }-- PoziomyTrudnosci : Poziom trudno쐁i
Pytania }-- Quizy : Zawiera
Odpowiedzi }-- Pytania : Zawiera
Wyniki }-- U퓓tkownicy : Przypisane do
Wyniki }-- Quizy : Zwi퉨ane z

@enduml
//

