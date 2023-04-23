# Tesztjegyzőkönyv

Tesztelő: Kaponya Martin

Operációs rendszer: Windows 10

Böngészők: Google Chrome, Mozilla Firefox, Opera

Ebben a dokumentumban lesz felsorolva az elvégzett tesztek elvárásai és eredményei, illetve időpontjai (Alfa, Béta és Végleges verzió).

## Alfa teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.04.21. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.04.21. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.21. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítotani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.21. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.21. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezni egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.04.21. | Fájl beolvasása a keresőbe | Adott fájlt ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.04.21. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |
| Átkonvertált fájlhash összehasonlítás | 2023.04.21. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az akutális hashünkhöz | Hibát találtam |

Az Alfa tesztelés során a minden pont hibátlanul működött, kivéve az összehasonlításnál, amit a további teszteknél javítva lesz.
A következő tesztelés során a többi funkció kerül vizsgálatra, tesztelésre.

Tesztelést végezte és írta: Kaponya Martin

Befejezve: 2023.04.21
