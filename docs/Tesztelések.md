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
| Átkonvertált fájlhash összehasonlítás | 2023.04.21. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát találtam |

Az Alfa tesztelés során a minden pont hibátlanul működött, kivéve az összehasonlításnál, amit a további teszteknél javítva lesz.
A következő tesztelés során a többi funkció kerül vizsgálatra, tesztelésre.

Tesztelést végezte és írta: Kaponya Martin

Befejezve: 2023.04.21

## Béta teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Átkonvertált fájlhash összehasonlítás | 2023.05.02. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát nem találtam |
| Frontend | 2023.05.02. | A frontend megjelenésének vizsgálata | Az oldalak designa elfogadható, átlátható. | Hibát nem találtam |
| Backend | 2023.05.02. | A backendben megírt kódok megfelelő működése | A backend kódjai a btnSend_Click gomb kódján kívül működnek. | Hibát részlegesen találtam |
| Menüpont tesztelés | 2023.05.02. | Scan gombbal megvizsgálja a fájl-t | Gombra kattintva és a lépéseket követve sikeresen átvizsgálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.02. | Delete gombbal törli a fájl-t | Gombra kattintva és a lépéseket követve sikeresen törli a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.02. | Check gombbal megkeressük a fájl-t | Gombra kattintva és a lépéseket követve sikeresen megtalálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.02. | Get gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen megkapjuk a fájl hashét. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.02. | Update gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen updateljük a fájl hashét. | Hibát nem találtam |

Az Alfa tesztben hibásan működő összehasonlítás mostmár javítva került tesztelésre.
A Béta teszt elkészült, a letesztelt funkciók megfelelően működtek a weboldalon, kivételt  képez a btnSend_Click funkció.
A végleges tesztelésnél prioritást élvez a Béta teszt során még hibásnak titulált funkció, majd újra ellenőrzésre kerülnek az összes funkció.

Tesztelést végezte és írta: Kaponya Martin

Befejezve: 2023.05.02

## Végleges teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.05.20. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.05.20. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.20. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.20. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.20. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezni egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.05.20. | Fájl beolvasása a keresőbe | Adott fájlt ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.05.20. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |
| Átkonvertált fájlhash összehasonlítás | 2023.05.20. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát nem találtam |
| Frontend | 2023.05.20. | A frontend megjelenésének vizsgálata | Az oldalak designa elfogadható, átlátható. | Hibát nem találtam |
| Backend | 2023.05.20. | A backendben megírt kódok megfelelő működése | A backend kódjai működnek. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.20. | Scan gombbal megvizsgálja a fájl-t | Gombra kattintva és a lépéseket követve sikeresen átvizsgálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.20. | Delete gombbal törli a fájl-t | Gombra kattintva és a lépéseket követve sikeresen törli a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.20. | Check gombbal megkeressük a fájl-t | Gombra kattintva és a lépéseket követve sikeresen megtalálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.20. | Get gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen megkapjuk a fájl hashét. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.20. | Update gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen updateljük a fájl hashét. | Hibát nem találtam |

A végleges teszt lezajlott, minden korábbi hiba javításra került, a program átadásra kész a megrendelőnek.

Tesztelést végezte és írta: Kaponya Martin

Befejezve: 2023.05.20.

# Tesztjegyzőkönyv

Tesztelő: Szabó Zsolt

Operációs rendszer: Windows 10

Böngészők: Opera, Google Chrome, Mozilla Firefox

A dokumentumban fel lesz sorolva az elvégzett tesztek kimentele, illetve elvárásai. Alfa, Béta és Végleges verzió külön ki lesz fejtve.

## Alfa teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.04.22. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.04.22. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.22. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítotani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.22. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.22. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezni egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.04.22. | Fájl beolvasása a keresőbe | Adott fájlt ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.04.22. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |
| Átkonvertált fájlhash összehasonlítás | 2023.04.22. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az akutális hashünkhöz | Hibát találtam |

Az Alfa tesztelés során a minden pont hibátlanul működött, kivéve az összehasonlításnál, amit a további teszteknél javítva lesz.
A következő tesztelés során tesztelésre kerül a többi funkció is.

Tesztelést végezte és írta: Szabó Zsolt

Befejezve:2023.04.22

## Béta teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Átkonvertált fájlhash összehasonlítás | 2023.05.04. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát nem találtam |
| Frontend | 2023.05.04. | A frontend megjelenésének vizsgálata | Az oldalak designa elfogadható, átlátható. | Hibát nem találtam |
| Backend | 2023.05.04. | A backendben megírt kódok megfelelő működése | A backend kódjai a btnSend_Click gomb kódján kívül működnek. | Hibát részlegesen találtam |
| Menüpont tesztelés | 2023.05.04. | Scan gombbal megvizsgálja a fájl-t | Gombra kattintva és a lépéseket követve sikeresen átvizsgálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.04. | Delete gombbal törli a fájl-t | Gombra kattintva és a lépéseket követve sikeresen törli a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.04. | Check gombbal megkeressük a fájl-t | Gombra kattintva és a lépéseket követve sikeresen megtalálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.04. | Get gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen megkapjuk a fájl hashét. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.04. | Update gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen updateljük a fájl hashét. | Hibát nem találtam |

Az Alfa tesztben hibásan működő összehasonlítás mostmár javítva került tesztelésre.
A Béta teszt elkészült, a letesztelt funkciók megfelelően működtek a weboldalon, kivételt  képez a btnSend_Click funkció.
A végleges tesztelésnél prioritást élvez a Béta teszt során még hibásnak titulált funkció, majd újra ellenőrzésre kerülnek az összes funkció.

Tesztelést végezte és írta: Szabó Zsolt

Befejezve:2023.05.04

## Végleges teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.05.21. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.05.21. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.21. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.21. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.21. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezni egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.05.21. | Fájl beolvasása a keresőbe | Adott fájlt ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.05.21. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |

# Tesztjegyzőkönyv

Tesztelő: Mihály Balázs

Operációs rendszer: Windows 10

Böngészők: Opera, Google Chrome, Mozilla Firefox

A dokumentumban fel lesz sorolva az elvégzett tesztek kimentele, illetve elvárásai. Alfa, Béta és Végleges verzió külön ki lesz fejtve.

## Alfa teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.04.23. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.04.23. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.23. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítotani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.23. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.04.23. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezn egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.04.23. | Fájl beolvasása a keresőbe | Adott fájl ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.04.23. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |
| Átkonvertált fájlhash összehasonlítás | 2023.04.23. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát találtam |

Az Alfa tesztelés során a minden pont hibátlanul működött, kivéve az összehasonlításnál, amit a további teszteknél javítva lesz.
A következő tesztelés során a többi funkció kerül vizsgálatra, tesztelésre.

Tesztelést végezte és írta: Mihály Balázs

Befejezve: 2023.04.23

## Béta teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Átkonvertált fájlhash összehasonlítás | 2023.05.10. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát nem találtam |
| Frontend | 2023.05.10. | A frontend megjelenésének vizsgálata | Az oldalak designa elfogadható, átlátható. | Hibát nem találtam |
| Backend | 2023.05.10. | A backendben megírt kódok megfelelő működése | A backend kódjai a btnSend_Click gomb kódján kívül működnek. | A leírt hibát találtam |
 Menüpont tesztelés | 2023.05.10. | Scan gombbal megvizsgálja a fájl-t | Gombra kattintva és a lépéseket követve sikeresen átvizsgálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.10. | Delete gombbal törli a fájl-t | Gombra kattintva és a lépéseket követve sikeresen törli a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.10. | Check gombbal megkeressük a fájl-t | Gombra kattintva és a lépéseket követve sikeresen megtalálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.10. | Get gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen megkapjuk a fájl hashét. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.10. | Update gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen updateljük a fájl hashét. | Hibát nem találtam |

Az Alfa tesztben hibásan működő összehasonlítás mostmár javítva került tesztelésre.
A Béta teszt elkészült, a letesztelt funkciók megfelelően működtek a weboldalon, kivételt  képez a btnSend_Click funkció.
A végleges tesztelésnél prioritást élvez a Béta teszt során még hibásnak titulált funkció, majd újra ellenőrzésre kerülnek az összes funkció.

Tesztelést végezte és írta: Mihály Balázs

Befejezve: 2023.05.10

## Végleges teszt

| Vizsgálat | Tesztelés időpontja | Elvárás | Eredmény | Hibák |
| :---: | --- | --- | --- | --- |
| Adatbázis | 2023.05.22. | Adatbázis működés ellenőrzése. | A táblák és az alkalmazás mezői sikeresen összekapcsolva, adatbázis adatok tárolására kész. | Hibát nem találtam |
| Hash Tesztelés | 2023.05.22. | Hash hozzáadása az adatbázishoz | Az adatbázishoz sikeresen hozzá tudtam adni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.22. | Hash módosítása az adatbázisban | Az adatbázisban sikeresen módosítani tudtam egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.22. | Hash törlése az adatbázisból | Az adatbázisból sikeresen ki tudtam törölni egy hash-t | Hibát nem találtam |
| Hash Tesztelés | 2023.05.22. | Hash lekérdezése. | Az adatbázisból sikeresen le tudtam kérdezni egy hash-t | Hibát nem találtam |
| Fájl beolvasása | 2023.05.22. | Fájl beolvasása a keresőbe | Adott fájlt ki tudtam választani és keresni az alkalmazásban | Hibát nem találtam |
| Fájl konvertálása | 2023.05.22. | Beolvasott fájl konvertálása | A beolvasott fájlt sikeresen konvertálta az alkalmazás | Hibát nem találtam |
| Átkonvertált fájlhash összehasonlítás | 2023.05.22. | Hashelt fájl összehasonlítása | Adatbázisba lévő hashekhez összehasonlítás az aktuális hashünkhöz | Hibát nem találtam |
| Frontend | 2023.05.22. | A frontend megjelenésének vizsgálata | Az oldalak designa elfogadható, átlátható. | Hibát nem találtam |
| Backend | 2023.05.22. | A backendben megírt kódok megfelelő működése | A backend kódjai működnek. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.22. | Scan gombbal megvizsgálja a fájl-t | Gombra kattintva és a lépéseket követve sikeresen átvizsgálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.22. | Delete gombbal törli a fájl-t | Gombra kattintva és a lépéseket követve sikeresen törli a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.22. | Check gombbal megkeressük a fájl-t | Gombra kattintva és a lépéseket követve sikeresen megtalálja a fájl-t | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.22. | Get gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen megkapjuk a fájl hashét. | Hibát nem találtam |
| Menüpont tesztelés | 2023.05.22. | Update gombbal megkapjuk a fájl hash-ét | Gombra kattintva és a lépéseket követve sikeresen updateljük a fájl hashét. | Hibát nem találtam |

A végleges teszt lezajlott, minden korábbi hiba javításra került, a program átadásra kész a megrendelőnek.

Tesztelést végezte és írta: Mihály Balázs

Befejezve: 2023.05.22