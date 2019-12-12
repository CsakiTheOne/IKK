# Bevezetés

### Specifikáció

A progaram egy segéd eszközként szolgál a mai magyar íróknak, költőknek. Segít kapcsolatok szerzésében, ihlet keresésben és főként az írásban. Ezzel a programmal talán többen is kezdenek alkotni és mégtöbben csodálhatják a magyar nyelv szépségeit.

### A szoftver használata

Belépéskor a felhasználó két dolgot láthat. Ha minden rendben, megjelenik a bejelentkező felület. Ha nincs internet, a program felajánlja az offline módot vagy próbálkozhat az eléréssel újra. Ha a bejelentkező felület jelenik meg, a regisztrálást is ugyanitt lehet megtenni, ha először jár erre a felhasználó. A bejelentkezést vagy az offline mód indítását követően megjelenik a főoldal és egy menü.

A főoldalon jelenig meg a napi idézet, a legfrissebb poszt, stb.. A profil menüpont alatt lehet megtekinteni és szerkeszteni a profilt, amivel épp be vagyunk jelentkezve. A verses fal hasonló lesz a közösségi oldalakhoz. A műveknél pedig az adatbázisban tárolt és legutóbbi műveket találjuk. Innen tudunk projektet kezdeni, megnyitni, szinkronizálni, stb..

Miközben a felhasználó a projekten dolgozik, oldalt látja és szerkesztheti a fő információkat és az eszközöket, középen a legnagyobb részt pedig a szöveg tölti ki.

# Felhasználói dokumentáció

### Profilok

A felhasználóknak van egy saját fiókja. Be és ki tudnak jelentkezni, a profilt tudják szerkeszteni. Ha esetleg nem szeretnék többé használni a programot, lekérhetik az adataikat és véglegesen törölhetik a fiókot.

Ebből áll egy fiók:

- E-mail
- Jelszó
- Név
- Magamról
- Utolsó idézet beküldés ideje
- Művek

### Saját profil szerkesztése

Bejelentkezés után a felhasználók átírhatják a nevüket, e-mail címűket, leírásukat és a régi jelszó megadásával új jelszót is adhatnak.

### Elfelejtett jelszó

Ha a felhasználó nem tudja a jelszavát, kérhet egy új, ideiglenes jelszót, amit meg kell változtatnia a legközelebbi sikeres bejelentkezéskor. Ezt az ideiglenes jelszót e-mailben kapja meg a felhasználó.

### Mások megtalálása

`TODO`

### Értesítések

A program ablak jobb alsó sarkában van egy állandó "Értesítések gomb". Itt lehet megnézni, rögzíteni, törölni az értesítéseket. Ezekek nagyrészt az eszközök küldik írás közben, de a jövőben bizonyos eseményekről is itt értesülhet a felhasználó.

### Offline mód, ha nincs internet

Ha a program nem éri el a szervert vagy nincs internet, akkor is működőképes. Az online letiltásra kerülnek, de minden mást lehet használni. Ugyanúgy lehet írni, olvasni, eszközöket állítgatni, fájlba menteni vagy azokból betölteni.

### Napi idézetek

Minden felhasználó naponta beküldhet 1db idézetet. Ezek az adatbázisban kerülnek tárolásra. A program minden nap kiválaszt ezekből véletlenszerúen egyet, amit megjelenít az összes felhasználónak.

### Verses fal

Ha a felhasználó befejezett egy projektet, megoszthatja azt a verses falra. Így a többi felhasználó is látja az alkotását. A mű mellett lehet egy kis szöveg is, kötelező elem pedig maga a felhasználó profilja. Alapértelmezetten a verses falon időrendi sorrendben megjelenik az összes poszt, de van lehetőség szűrésre és keresésre.

### Művek létrehozása és kezelése

`TODO`

### Szövegszerkesztő

A programban lehet szöveget írni a sima jegyzettömbhöz hasonlóan. Írás közben jelenhetnek meg értesítések, jelek, amik az eszközök funkcióhoz kapcsolódnak.

### Írás: az eszközök

Egy projekthez adhat a felhasználó eszközöket. Ezek segítik az írást a felhasználó számára. Például egy eszköz figyelheti a szóismétlést és ajánlhat szinonímákat helyette. Vagy figyelheti a sorok számát és a rímeket a felhasználó által megadott beállítások alapján.

Az eszközök többször is felhasználhatók több projektben. Például a felhasználó csinál egy új projektet "Haiku" néven. Nem ír bele semmit, csak hozzáad 2 eszközt és beállítja őket. Ezt követően a felhasználó csinál egy másik projektet az eszközökhöz lép és ott nyitja meg a "Haiku" projektet. Így minden eszköz és beállítás átjött ebbe a projektbe.

### Támogatott formátumok

A projekteket el lehet menteni és be lehet tölteni eszközökkel együtt. Amiken legutóbb dolgozott a felhasználó, megjelennek a "Művek" menüpont alatt.

A program több formátumot is támogat:

| Formátum        | .    | Leírás                                                         |
| --------------- | ---- | -------------------------------------------------------------- |
| Egyszerű szöveg | txt  | Eszközök a fájl végén speciális karakterekkel jelölve.         |
| Markdown fájl   | md   | Nagy cím, sima szöveg, eszközök a jájl végén táblázatban.      |
| Bináris fájl    | ikk  | Csak ez a program tudja olvasni.                               |
| Felhő           | -    | Adatbázisban tárolt projektek mindig megjelennek a programban. |
| Weboldal        | html | CSAK EXPORTÁLÁS                                                |

### Szinkronizálás

A projektek tárolása az adatbázisban egy könnyű módot kínál, hogy a felhasználók "magukkal vigyék" verseiket, novelláikat. Ha valaki föltölti oda egy művét, onnantól a profiljához kötve bárhol megtalálja. Elég csak bejelentkezni.

### Témák

A program nagyon testreszabható és a felhasználók kedvükre állíthatják a színeket. A téma motornak köszönhetően ezek futás időben, újraindítás nélkül frissülnek.

### Rendszer követelmények

`TODO`

# Fejlesztői dokumentáció

### Adatbázis szerkezete

Táblák:

- Felhasználók
- Művek
- Eszközök
- (Napi) Idézetek
- Posztok (verses fal)

### Kommunikáció az adatbázissal

MySQLConnector nevű NuGet csomagot használja a program. Ez az Oracle SQL-es NuGet csomagjának egy nyílt forráskódú fork-ja.

### Munkamenet

Miután a felhasználó bejelentkezett, a program eltárolja, hogy ki is ő. Egy azonosítót kap, ami alapján meg lehet találni. Ezt használja a program sok művelethez. Pl. a verses fal funkcióihoz. (Megosztás, kedvelés.)

### Kapcsolat teszt és offline mód

`TODO`

### Eszközök működése

`TODO`

### Támogatott formátumok

`TODO`

### Exportálás és feltöltés

`TODO`

### Verses fal (és like-ok)

`TODO`

### Fejlesztési tervek

`TODO`