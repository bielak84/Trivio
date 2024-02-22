@startuml
entity "U퓓tkownicy" {
  + ID_Uzytkownika (PK, INT, AutoIncrement)
  Login (VARCHAR)
  Haslo (VARCHAR, zaszyfrowane)
  Email (VARCHAR)
  Rola (VARCHAR)
}

entity "Quizy" {
  + ID_Quizu (PK, INT, AutoIncrement)
  ID_Tworcy (FK, U퓓tkownicy.ID_Uzytkownika)
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

entity "Uprawnienia" {
  + ID_Uprawnienia (PK, INT, AutoIncrement)
  Rodzaj (VARCHAR)
}

U퓓tkownicy }-- Uprawnienia : Posiada

U퓓tkownicy --{ Quizy : Tworzy
Quizy }-- Pytania : Zawiera
Pytania }-- Odpowiedzi : Zawiera
Wyniki }-- U퓓tkownicy : Przypisane do
Wyniki }-- Quizy : Zwi쉦ane z
@enduml
