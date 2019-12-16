# Tartalomjegyzék

- Bevezetés
  - Specifikáció
  - A szoftver használata
- Felhasználói dokumentáció
  - Profilok
  - Saját profil szerkesztése
  - Elfelejtett jelszó
  - Más felhasználók megtalálása
  - Értesítések
  - Offline mód, ha nincs internet
  - Napi idézetek
  - Verses fal
  - Művek létrehozása és kezelése
  - Szövegszerkesztő
  - Írás: az eszközök
  - Támogatott formátumok
  - Szinkronizálás
  - Témák
  - Rendszer követelmények
- Fejlesztői dokumentáció
  - Adatbázis szerkezete
  - Kommunikáció az adatbázissal
  - Munkamenet
  - Kapcsolat teszt és offline mód
  - Eszközök működése
  - Támogatott formátumok
  - Exportálás és feltöltés
  - Verses fal (és like-ok)
  - Fejlesztési tervek

# Bevezetés

## Specifikáció

A progaram egy segéd eszközként szolgál a mai magyar íróknak, költőknek. Segít kapcsolatok szerzésében, ihlet keresésben és főként az írásban. Ezzel a programmal talán többen is kezdenek alkotni és mégtöbben csodálhatják a magyar nyelv szépségeit.

## A szoftver használata

Belépéskor a felhasználó két dolgot láthat. Ha minden rendben, megjelenik a bejelentkező felület. Ha nincs internet, a program felajánlja az offline módot vagy próbálkozhat az eléréssel újra. Ha a bejelentkező felület jelenik meg, a regisztrálást is ugyanitt lehet megtenni, ha először jár erre a felhasználó. A bejelentkezést vagy az offline mód indítását követően megjelenik a főoldal és egy menü.

A főoldalon jelenig meg a napi idézet, a legfrissebb poszt, stb.. A profil menüpont alatt lehet megtekinteni és szerkeszteni a profilt, amivel épp be vagyunk jelentkezve. A verses fal hasonló lesz a közösségi oldalakhoz. A műveknél pedig az adatbázisban tárolt és legutóbbi műveket találjuk. Innen tudunk projektet kezdeni, megnyitni, szinkronizálni, stb..

Miközben a felhasználó a projekten dolgozik, oldalt látja és szerkesztheti a fő információkat és az eszközöket, középen a legnagyobb részt pedig a szöveg tölti ki.

# Felhasználói dokumentáció

## Profilok

A felhasználóknak van egy saját fiókja. Be és ki tudnak jelentkezni, a profilt tudják szerkeszteni. Ha esetleg nem szeretnék többé használni a programot, lekérhetik az adataikat és véglegesen törölhetik a fiókot.

Ebből áll egy fiók:

- E-mail
- Jelszó
- Név
- Magamról
- Utolsó idézet beküldés ideje
- Művek

## Saját profil szerkesztése

Bejelentkezés után a felhasználók átírhatják a nevüket, e-mail címűket, leírásukat és a régi jelszó megadásával új jelszót is adhatnak maguknak. Ezeket a funkciókat könnyen elérhetik a "Profil" menüpont alatt.

## Elfelejtett jelszó

Ha a felhasználó nem tudja a jelszavát, kérhet egy új, ideiglenes jelszót, amit meg kell változtatnia a legközelebbi sikeres bejelentkezéskor. Ezt az ideiglenes jelszót e-mailben kapja meg a felhasználó.

## Más felhasználók megtalálása

A szoftver egy közösségi oldalként is funkcionál. Ezért fontos, hogy megtaláljunk más embereket benne. Nem csak a verses falon látjuk, hogy ki osztott meg egy művet, hanem rá is kereshetünk egy személyre.

## Értesítések

A program ablak jobb alsó sarkában van egy állandó "Értesítések" gomb. Itt lehet megnézni, rögzíteni, törölni az értesítéseket. Ezekek nagyrészt az eszközök küldik írás közben, de a jövőben bizonyos eseményekről is itt értesülhet a felhasználó.

## Offline mód, ha nincs internet

Ha a program nem éri el a szervert vagy nincs internet, akkor is működőképes. Az online funkciók letiltásra kerülnek, de minden mást lehet használni. Ugyanúgy lehet írni, olvasni, eszközöket állítgatni, fájlba menteni vagy azokból betölteni.

## Napi idézetek

Minden felhasználó naponta beküldhet 1db idézetet. Ezek az adatbázisban kerülnek tárolásra. A program minden nap kiválaszt ezekből véletlenszerúen egyet, amit megjelenít az összes felhasználónak. Az idézet mellett megjelenik az is, aki az idézetet beküldte.

## Verses fal

Ha a felhasználó befejezett egy projektet, megoszthatja azt a verses falra. Így a többi felhasználó is látja az alkotását. A mű mellett lehet egy kis szöveg is, kötelező elem pedig maga a felhasználó profilja. Alapértelmezetten a verses falon időrendi sorrendben megjelenik az összes poszt, de van lehetőség szűrésre és keresésre.

## Művek létrehozása és kezelése

Egy új művet írni olyan, mint bármelyik programban. Itt is ha rákattintunk az "Új projekt" gombra, már írhatjuk is. Ezt menthetjük bárhová, betölthetjük, hogy folytassunk egy megkezdett verset stb.. Amivel az én programom több egy notepad-nál, az az, hogy a legutóbbi projektek megjelennek a programban. Nem kell megkeresni a sok fájl között, hogy folytassunk egy művet. Viszont vannak, akik inkább a fájlok között szeretik rendezgetni a projektjeiket. Szóval ha törlünk vagy áthelyezünk egy projekt fájlt, akkor a programban azok az elérési útvonalak is eltűnnek.

## Szövegszerkesztő

A programban lehet szöveget írni a sima jegyzettömbhöz hasonlóan. Írás közben jelenhetnek meg értesítések, jelek, amik az eszközök funkcióhoz kapcsolódnak. Pont, mint egy kódszerkesztő szoftverben.

## Írás: az eszközök

Egy projekthez adhat a felhasználó eszközöket. Ezek segítik az írást a felhasználó számára. Például egy eszköz figyelheti a szóismétlést és ajánlhat szinonímákat helyette. Vagy figyelheti a sorok számát és a rímeket a felhasználó által megadott beállítások alapján.

Az eszközök többször is felhasználhatók több projektben. Például a felhasználó csinál egy új projektet "Haiku" néven. Nem ír bele semmit, csak hozzáad 2 eszközt és beállítja őket. Ezt követően a felhasználó csinál egy másik projektet az eszközökhöz lép és ott nyitja meg a "Haiku" projektet. Így minden eszköz és beállítás átjött ebbe a projektbe.

## Támogatott formátumok

A projekteket el lehet menteni és be lehet tölteni eszközökkel együtt. Amiken legutóbb dolgozott a felhasználó, megjelennek a "Művek" menüpont alatt.

A program több formátumot is támogat:

| Formátum        | .    | Leírás                                                         |
| --------------- | ---- | -------------------------------------------------------------- |
| Egyszerű szöveg | txt  | Eszközök a fájl végén speciális karakterekkel jelölve.         |
| Markdown fájl   | md   | Nagy cím, sima szöveg, eszközök a jájl végén táblázatban.      |
| Bináris fájl    | ikk  | Csak ez a program tudja olvasni.                               |
| Felhő           | -    | Adatbázisban tárolt projektek mindig megjelennek a programban. |
| Weboldal        | html | CSAK EXPORTÁLÁS                                                |

## Szinkronizálás

A projektek tárolása az adatbázisban egy könnyű módot kínál, hogy a felhasználók "magukkal vigyék" verseiket, novelláikat. Ha valaki föltölti oda egy művét, onnantól a profiljához kötve bárhol megtalálja. Elég csak bejelentkezni.

## Témák

A program nagyon testreszabható és a felhasználók kedvükre állíthatják a színeket. A téma motornak köszönhetően ezek futás időben, újraindítás nélkül frissülnek.

## Rendszer követelmények

dotNET keretrendszer 4.7.2 és Windows 10 operációs rendszer.

# Fejlesztői dokumentáció

## Adatbázis szerkezete

Táblák:

- Felhasználók
- Művek
- Eszközök
- (Napi) Idézetek
- Posztok (verses fal)
- Kedvelések

## Kommunikáció az adatbázissal

MySQLConnector nevű NuGet csomagot használja a program. Ez az Oracle SQL-es NuGet csomagjának egy nyílt forráskódú fork-ja. Az adatbázisban tárolt eljárások találhatóak, ezeket hívja meg a program, nem pedig közvetlen SQL utasításokat küld.

## Munkamenet

Miután a felhasználó bejelentkezett, a program eltárolja, hogy ki is ő. Egy azonosítót kap, ami alapján meg lehet találni. Ezt használja a program sok művelethez. Pl. a verses fal funkcióihoz. (Megosztás, kedvelés.)

## Kapcsolat teszt és offline mód

A program indulások teszteli, hogy eléri-e az adatbázist. Ehhez nem használ mást, mint az adatbázist magát. Megpróbál kapcsolódni és egy egyszerű lekérdezést hajt végre, hogy meggyőződjön a kapcsolatról. Ha valami gond van, a program offline módba lép és a háttérben teszteli tovább a kapcsolatot. Ha offline módban van a program és egy sikeres teszt végződik, akkor értesítést kap a felhasználó, hogy mostmár online használhatja a programot.

## Eszközök működése

Egy `Tool` osztályból származik minden eszköz, így lehet egy kategóriába rakni őket. De mégis mindegyik mást csinál. A `Tool` nevű osztálynak van egy `OnChange` és egy `OnLoad` függvénye, amik a projekt tartalmát kérik be és értesítést adnak vissza, ha kell. Az `OnLoad` a projekt betöltésekor vagy az eszköz hozzáadásakor egyszer fut le, az `OnChange` pedig minden alkalommal, amikor a projekt tartalma változik.

## Támogatott formátumok

##### IKK

Az ajánlott formatum a programhoz. Bináris fájl, ami mindent eltárol és csak ez a program tudja olvasni. Hogyan működik? A programban egy `Project` osztály található, amin egy attribútum szerepel: `System.Serializable`. Így az osztályt könnyen fájlba lehet írni és abból vissza.

##### TXT

A legegyszerűbb formátum, amit minden program megért. Nem volt egyszerű veszteségmentesen egy sima szöveges állományba rakni mindent, de végül sikerült, az eszközökkel együtt.

##### MD

Ez a formátum szép / átlátható dokumentumok gyors és könnyű írására lett kitalálva. A fejlesztők ebben írják a dokumentációt és minden GitHub projektnek kötelező eleme. Ez az ajánlott formátum, ha a felhasználó nem szeretne bináris fájlt készíteni.

##### Felhő

A műveket föl lehet tölteni a program adatbázisába. Így a felhasználók vihetik magukkal, csak be kell jelentkeziük.

##### Weboldal

Ebben a formátumban nem menteni, hanem csak exportálni lehet. A program tartalmaz egy egyszerű HTML kódot és annak a részeit cserélgeti a projekt elemeivel. Minden elemre rak egy id-t vagy osztályt, hogy könnyen témázható is legyen CSS-el. Azt nem generál a program.

## Exportálás és feltöltés

Az adatbázis `Project` táblája ad lehetőséget művek tárolására a felhőben. A projektet magát és a hozzá tartozó eszközöket külön tábla tárolja.

## Verses fal (és like-ok)

Bárki írhat bejegyzést a verses falra, ez lehet sim szöveg vagy egy csatolt mű. Mielőtt a felhasználó csatol egy projektet, fel kell töltenie a adatbázisba. Ha onnan törlni, a posztban sem lesz a mű elérhető. Az Integrált Költészeti Környezet egy közösségi oldalként is funkcionál, szóval adni kell lehetőséget a felhasználóknak, hogy visszajelzést adjanak egymásnak. Erre szolgálnak a szívek. (Like funkció.) Minden felhasználó egy posztot csak egyszer kedvelhet. Ez egy külön táblával van megoldva az adatbázisban.

## Fejlesztési tervek

Szeretném ha a programom a lehető legjobban testreszabható lenne. Nem csak a kinézetét tekintve, hanem működés szempontjából is. A téma motor és saját profil mellett ezért is szeretném, hogy mod támogatás legyen a szoftverben. Ezekkel akár új eszközöket is lehessen a programba tenni.
