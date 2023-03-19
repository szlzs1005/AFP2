# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása

Jelenleg a megrendelő cég a számítógépeit védelem nélkül ellátva adja ki a dolgozóknak és gyakran felmerülő probléma hogy a dolgozók beleszaladnak egy-egy vírusba. Ezeknek a vírusoknak a megtalálása és kiírtása feleslegesen sok idő elvesznek a rendszergazdáktól. Arról nem is beszélve, hogy amíg a dolgozónál nincs a laptop, nem tudja a munkát folytatni. Esetenként megtörténik az is, hogy menhetetlen a gép és újra kell telepíteni, így esetleges adatokat veszít a dolgozó, ami létszükséglet volt a munkájához. Ezen felmerülő problémákat szeretnénk megoldani, illetve megkönnyíteni. A megrendelő mindeképpen egy mindenki által könnyen használható felületet szeretne, ami mindenki számára evidens a használata. A program nem csak a köztudatban ismert vírusokat tudja detektálni, hanem lehetőség van "egyéni szabályok" létrehozására is. Olyan file-ok is kiszűrhetőek, amik szokványos vírust nem tartalmaznak, viszont olyan tartalmaz igen, ami a cég szempontjából kockázatot jelent. Ezáltal sokkal könnyebb a céges policy-t az IT részlegen is érvényesteni.

## 2. Vágyálomrendszer leírása

A megrendelő olyan felületet szeretne, ami lehetővé teszi egy számítógép teljes diagnosztizálását vírusokat keresve, és az esetleges felmerülő vírusokat kigyomlálni, így nem a rendszergazdákat terheléni ez a feladat is. Jelenleg a számítógépeken semmilyen védelmi eszköz nincs, így kitéve azokat a rengeteg veszélynek ami az interneten terjeng. A telepítéshez rendszergazdai jogosultság kell, azonban a használatához már az átlag felhasználó is hozzáfér. Tud futtatni egy diagnosztikát, ami átfésüli a számítógépet vírusokat keresve. Ha talált, akkor annak elhárításában is segít.

## 3. Jelenlegi üzleti folyamatok modellje

A jelenlegi renszerben minden számítógép védelem mentesen kerül a dolgozókhoz, ezzel kitéve őket a veszélynek hogy káros szoftvert töltsenek le vagy fájlt kaphatnak emailben. Miután a baj megtörtént a rendszergazdákhoz fordulnak, akik a jobb esetben is 1-2 nap tudják megszüntetni a probláémát, ami alatt a dolgozó nem tud haladni a határidős munkákkal. Ezt a folyamatatot szeretnék leredukálni egy programra ami, ezt automatizálja és felgyorsítja.

## 4. Igényelt üzleti folyamatok modellje

A megrendelő dolgozói bármikor különösebb ídőt nem igényelve le tudjanak futtatni egy elemző sessiont, ami végigfürkészi a számítógép tárhelyét károkozók után kutatva. Mappa kiválasztása után a felhasználó egy jól látható, kiolvasható felületen kapjon tájékoztatást, hogy mely file-ok nem mentek át a szűrőn, illetve legyen lehetőség ezek azonnal törlésére.

## 5. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Felület | Search | Vírus keresése, lefutás után státusz visszajelzés. |
| K2 | Felület | Delete | Talált vírus esetén, annak törlése. |
| K3 | Felület | Modify | Vírus hash módosítása esetleges vírusfejlődés esetén. |
| K4 | Felület | Add | Új vírus hozzáadása adatbázisunkhoz. |

## 6. Használati esetek

A felhasználó elővigyázatosságból lefuttatja a keresést, hogy saját munkáját is megkönnyítse.
A rendszergazda manuálisan, ismétlőlegesen lefuttatja a keresést bizonyos periódusonként.
A rendzsergazda beütemezi az automatikus átvizsgálást, azaz a program lefuttatását.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

K1: A fertőzött fájlt megkeresi.
K2: A vírust törli az eszközről.
K3: Régebbi vírus, amely evolávlódott, így annak elérése és megkeresése is megváltozott.
K4: Új, tovább szofisztikáltabb vírus hozzáadása.

## 8. Képernyőtervek

![Képernyőterv](/docs/pics/1.png)

![Képernyőterv2](/docs/pics/2.png)

## 9. Forgatókönyvek

Mivel a cég nem követeli meg az informatika ezenszintű ismeretét, ezért dolgozóitól nem várható el, hogy minden gyanús, vagy ténylegesen káros filet ki tudjanak szűrni. Ezért rohamosan megnőtt a vírusok miatt keletkezett kellemetlenségek és lassulások, ezért a megrendelő egy szoftvert szeretne, amivel ezt valamilyen szinte vissza tudja szorítani. 
