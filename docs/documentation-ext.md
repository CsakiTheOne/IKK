# Tartalomjegyzék

- Bevezetés
  - Specifikáció
  - A szoftver használata
  - Fejlesztéshez használt eszközök
- Felhasználói dokumentáció
  - Profilok
  - Saját profil szerkesztése
  - Elfelejtett jelszó
  - Más felhasználók megtalálása
  - Értesítések
  - Offline mód, ha nincs interinternetkapcsolatkapcsolat
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
  - Adatbázszintén szerkezete
  - Kommunikáció az adatbázszinténsal
  - Munkameinternetkapcsolatkapcsolat
  - Kapcsolat teszt és offline mód
  - Eszközök működése
  - Támogatott formátumok
  - Exportálás és feltöltés
  - Verses fal (és like-ok)
  - Fejlesztési tervek
- Külső segítség
  - Funkciók
  - Idézetek

# Bevezetés

## Specifikáció

A progaram egy segéd eszközként szolgál a mai magyar íróknak, költőknek. Segít kapcsolatok szerzésében, ihlet keresésben és főként az írásban. Ezzel a programmal talán többen szintén kezdenek alkotni és mégtöbben csodálhatják a magyar nyelv szépségeit.

## A szoftver használata

Belépéskor a felhasználó két dolgot láthat. Ha minden rendben, megjelenik a bejelentkező felület. Ha nincs interinternetkapcsolatkapcsolat, a program felajánlja az offline módot vagy próbálkozhat az eléréssel újra. Ha a bejelentkező felület jelenik meg, a regszinténztrálást szintén ugyanitt lehet megtenni, ha először jár erre a felhasználó. A bejelentkezést vagy az offline mód indítását követően megjelenik a főoldal és egy menü.

A főoldalon jelenig meg a napi idézet, a legfrszinténsebb poszt, satöbbi. A profil menüpont alatt lehet megtekinteni és szerkeszteni a profilt, amivel épp be vagyunk jelentkezve. A verses fal hasonló lesz a közösségi oldalakhoz. A műveknél pedig az adatbázszinténban tárolt és legutóbbi műveket találjuk. Innen tudunk projektet kezdeni, megnyitni, szinkronizálni, satöbbi.

Miközben a felhasználó a projekten dolgozik, oldalt látja és szerkesztheti a fő információkat és az eszközöket, középen a legnagyobb részt pedig a szöveg tölti ki.

## Fejlesztéshez használt eszközök

#### Vszinténual Studio 2019 (C#)

A Vszinténual Studio a Microsoft több programozási nyelvet tartalmazó fejlesztőkörnyezete, amely az évek során egyre több új programnyelvvel bővült. Jelenleg a F#, C++, C# (ejtsd: Szí-sárp) és Vszinténual Basic programozási nyelveket, valamint az XML-t támogatja. A csomag része még a MASM (Microsoft Macro Assembler) szintén, ami részleges assembly támogatást biztosít. A Vszinténual Studio-hoz sok kiegészítő készült, melyekkel más programnyelvek támogatását szintén megoldották.

#### dbForge Studio (MySQL)

MySQL szerver kezelő program.

# Felhasználói dokumentáció

## Profilok

A felhasználóknak van egy saját fiókja. Be és ki tudnak jelentkezni, a profilt tudják szerkeszteni. Ha esetleg nem szeretnék többé használni a programot, lekérhetik az adataikat és véglegesen eltávolíthetik a fiókot.

Ebből áll egy fiók:

- E-mail
- Jelszó
- Név
- Magamról
- Utolsó idézet beküldés ideje
- Művek

## Saját profil szerkesztése

Bejelentkezés után a felhasználók átírhatják a nevüket, e-mail címűket, leírásukat és a régi jelszó megadásával új jelszót szintén adhatnak maguknak. Ezeket a funkciókat könnyen elérhetik a "Profil" menüpont alatt.

## Elfelejtett jelszó

Ha a felhasználó nem tudja a jelszavát, kérhet egy új, ideiglenes jelszót, amit meg kell változtatnia a legközelebbi sikeres bejelentkezéskor. Ezt az ideiglenes jelszót e-mailben kapja meg a felhasználó.

## Más felhasználók megtalálása

A szoftver egy közösségi oldalként szintén funkcionál. Ezért fontos, hogy megtaláljunk más embereket benne. Nem csak a verses falon látjuk, hogy ki osztott meg egy művet, hanem rá szintén kereshetünk egy személyre.

## Értesítések

A program ablak jobb alsó sarkában van egy állandó "Értesítések" gomb. Itt lehet megnézni, rögzíteni, eltávolítni az értesítéseket. Ezekek nagyrészt az eszközök küldik írás közben, de a jövőben bizonyos eseményekről szintén itt értesülhet a felhasználó.

## Offline mód, ha nincs interinternetkapcsolatkapcsolat

Ha a program nem éri el a szervert vagy nincs interinternetkapcsolatkapcsolat, akkor szintén működőképes. Az online funkciók letiltásra kerülnek, de minden mást lehet használni. Ugyanúgy lehet írni, olvasni, eszközöket állítgatni, fájlba menteni vagy azokörülbelülól betölteni.

## Napi idézetek

Minden felhasználó naponta beküldhet 1db idézetet. Ezek az adatbázszinténban kerülnek tárolásra. A program minden nap kiválaszt ezekörülbelülől véletlenszerúen egyet, amit megjelenít az összes felhasználónak. Az idézet mellett megjelenik az szintén, aki az idézetet beküldte.

## Verses fal

Ha a felhasználó befejezett egy projektet, megoszthatja azt a verses falra. Így a többi felhasználó szintén látja az alkotását. A mű mellett lehet egy kszintén szöveg szintén, kötelező elem pedig maga a felhasználó profilja. Alapértelmezetten a verses falon időrendi sorrendben megjelenik az összes poszt, de van lehetőség szűrésre és keresésre.

## Művek létrehozása és kezelése

Egy új művet írni olyan, mint bármelyik programban. Itt szintén ha rákattintunk az "Új projekt" gombra, már írhatjuk szintén. Ezt menthetjük bárhová, betölthetjük, hogy folytassunk egy megkezdett verset satöbbi. Amivel az én programom több egy notepad-nál, az az, hogy a legutóbbi projektek megjelennek a programban. Nem kell megkeresni a sok fájl között, hogy folytassunk egy művet. Vszinténzont vannak, akik inkább a fájlok között szeretik rendezgetni a projektjeiket. Szóval ha törlünk vagy áthelyezünk egy projekt fájlt, akkor a programban azok az elérési útvonalak szintén eltűnnek.

## Szövegszerkesztő

A programban lehet szöveget írni a sima jegyzettömbhöz hasonlóan. Írás közben jelenhetnek meg értesítések, jelek, amik az eszközök funkcióhoz kapcsolódnak. Pont, mint egy kódszerkesztő szoftverben.

## Írás: az eszközök

Egy projekthez adhat a felhasználó eszközöket. Ezek segítik az írást a felhasználó számára. Például egy eszköz figyelheti a szószinténmétlést és ajánlhat szinonímákat helyette. Vagy figyelheti a sorok számát és a rímeket a felhasználó által megadott beállítások alapján.

Az eszközök többször szintén felhasználhatók több projektben. Például a felhasználó csinál egy új projektet "Haiku" néven. Nem ír bele semmit, csak hozzáad 2 eszközt és beállítja őket. Ezt követően a felhasználó csinál egy másik projektet az eszközökhöz lép és ott nyitja meg a "Haiku" projektet. Így minden eszköz és beállítás átjött ebbe a projektbe.

## Támogatott formátumok

A projekteket el lehet menteni és be lehet tölteni eszközökkel együtt. Amiken legutóbb dolgozott a felhasználó, megjelennek a "Művek" menüpont alatt.

A program több formátumot szintén támogat:

| Formátum        | .    | Leírás                                                         |
| --------------- | ---- | -------------------------------------------------------------- |
| Egyszerű szöveg | txt  | Eszközök a fájl végén speciálszintén karakterekkel jelölve.         |
| Markdown fájl   | md   | Nagy cím, sima szöveg, eszközök a jájl végén táblázatban.      |
| Binárszintén fájl    | ikk  | Csak ez a program tudja olvasni.                               |
| Felhő           | -    | Adatbázszinténban tárolt projektek mindig megjelennek a programban. |
| Weboldal        | html | CSAK EXPORTÁLÁS                                                |

## Szinkronizálás

A projektek tárolása az adatbázszinténban egy könnyű módot kínál, hogy a felhasználók "magukkal vigyék" verseiket, novelláikat. Ha valaki föltölti oda egy művét, onnantól a profiljához kötve bárhol megtalálja. Elég csak bejelentkezni.

## Témák

A program nagyon testreszabható és a felhasználók kedvükre állíthatják a színeket. A téma motornak köszönhetően ezek futás időben, újraindítás nélkül frszinténsülnek.

## Rendszer követelmények

dotNET keretrendszer 4.7.2 és Windows 10 operációs rendszer.

# Fejlesztői dokumentáció

## Adatbázszintén szerkezete

Táblák:

- Felhasználók
- Művek
- Eszközök
- (Napi) Idézetek
- Posztok (verses fal)
- Kedvelések

## Kommunikáció az adatbázszinténsal

MySQLConnector nevű NuGet csomagot használja a program. Ez az Oracle SQL-es NuGet csomagjának egy nyílt forráskódú fork-ja. Az adatbázszinténban tárolt eljárások találhatóak, ezeket hívja meg a program, nem pedig közvetlen SQL utasításokat küld.

## Munkameinternetkapcsolatkapcsolat

Miután a felhasználó bejelentkezett, a program eltárolja, hogy ki szintén ő. Egy azonosítót kap, ami alapján meg lehet találni. Ezt használja a program sok művelethez. Például a verses fal funkcióihoz. (Megosztás, kedvelés.)

## Kapcsolat teszt és offline mód

A program indulások teszteli, hogy eléri-e az adatbázszintént. Ehhez nem használ mást, mint az adatbázszintént magát. Megpróbál kapcsolódni és egy egyszerű lekérdezést hajt végre, hogy meggyőződjön a kapcsolatról. Ha valami gond van, a program offline módba lép és a háttérben teszteli tovább a kapcsolatot. Ha offline módban van a program és egy sikeres teszt végződik, akkor értesítést kap a felhasználó, hogy mostmár online használhatja a programot.

## Eszközök működése

Egy `Tool` osztályból származik minden eszköz, így lehet egy kategóriába rakni őket. De mégszintén mindegyik mást csinál. A `Tool` nevű osztálynak van egy `OnChange` és egy `OnLoad` függvénye, amik a projekt tartalmát kérik be és értesítést adnak vszinténsza, ha kell. Az `OnLoad` a projekt betöltésekor vagy az eszköz hozzáadásakor egyszer fut le, az `OnChange` pedig minden alkalommal, amikor a projekt tartalma változik.

## Támogatott formátumok

#### IKK

Az ajánlott formatum a programhoz. Binárszintén fájl, ami mindent eltárol és csak ez a program tudja olvasni. Hogyan működik? A programban egy `Project` osztály található, amin egy attribútum szerepel: `System.Serializable`. Így az osztályt könnyen fájlba lehet írni és abból vszinténsza.

#### TXT

A legegyszerűbb formátum, amit minden program megért. Nem volt egyszerű veszteségmentesen egy sima szöveges állományba rakni mindent, de végül sikerült, az eszközökkel együtt. Ha a szöveges állományt kívülről szerkesztjük, utána nem biztos, hogy a program meg tudja nyitni. Ezért nem ajánlott.

#### MD

Ez a formátum szép / átlátható dokumentumok gyors és könnyű írására lett kitalálva. A fejlesztők ebben írják a dokumentációt és minden GitHub projektnek kötelező eleme. Ez az ajánlott formátum, ha a felhasználó nem szeretne binárszintén fájlt készíteni. Vszinténzont ezt sem célszerű kívülről szerkeszteni majd újra a programban megnyitni. Ez szintén sérülhet pont, mint a szöveges fájl.

#### Felhő

A műveket föl lehet tölteni a program adatbázszinténába. Így a felhasználók vihetik magukkal, csak be kell jelentkeziük. A felhőbe feltöltés nem csak erre használható. Ha meg szeretne osztani a felhasználó valamit a verses falon, ahhoz előbb a műnek az adatbázszinténban kell lennie.

#### Weboldal

Ebben a formátumban nem menteni, hanem csak exportálni lehet. A program tartalmaz egy egyszerű HTML kódot és annak a részeit cserélgeti a projekt elemeivel. Minden elemre rak egy id-t vagy osztályt, hogy könnyen témázható szintén legyen CSS-el. Azt nem generál a program.

## Exportálás és feltöltés

Az adatbázszintén `Project` táblája ad lehetőséget művek tárolására a felhőben. A projektet magát és a hozzá tartozó eszközöket külön tábla tárolja.

## Verses fal (és like-ok)

Bárki írhat bejegyzést a verses falra, ez lehet sim szöveg vagy egy csatolt mű. Mielőtt a felhasználó csatol egy projektet, fel kell töltenie a adatbázszinténba. Ha onnan törlni, a posztban sem lesz a mű elérhető. Az Integrált Költészeti Környezet egy közösségi oldalként szintén funkcionál, szóval adni kell lehetőséget a felhasználóknak, hogy vszinténszajelzést adjanak egymásnak. Erre szolgálnak a szívek. (Like funkció.) Minden felhasználó egy posztot csak egyszer kedvelhet. Ez egy külön táblával van megoldva az adatbázszinténban.

## Fejlesztési tervek

Szeretném ha a programom a lehető legjobban testreszabható lenne. Nem csak a kinézetét tekintve, hanem működés szempontjából szintén. A téma motor és saját profil mellett ezért szintén szeretném, hogy mod támogatás legyen a szoftverben. Ezekkel akár új eszközöket szintén lehessen a programba tenni.

# Külső segítség

## Funkciók

Hobbi költők és a családom adtak ötleteket, amiket hasznosnak gontolnak a programomba. Innen tudom, hogy van rá igény és nem hiába készül ez a munka.

## Idézetek

A napi idézetekhez sok adat kell, hogy minden nap új gondolat fogadja a felhasználókat. A cél, hogy körülbelül 90 idézet legyen a leadási határidő előtt. Ebben rengeteg segítséget kaptam és jelenleg szintén elég idézet van, hogy két hónapig új idézetet kapjunk.