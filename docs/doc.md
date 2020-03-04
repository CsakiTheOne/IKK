# Borító

// WORD

# Tartalomjegyzék

// WORD

# Bevezetés, specifikáció

A magyar költészet mindig is fontos szerepet játszott a történelmünkben. Míg régen papírravetették a költők a gondolataikat, a mai fiatalok már inkább a telefonjukat, gépüket használják megosztásra. Vannak verses csoportok, íróknak szóló közösségi oldal is, de nincs egy kifejezetten erre a célra kitalált hely. A program nem csak közösségi platformként működik, hanem különböző eszközöket is tartalmaz az írás megkönnyítéséhez.

A közösségi rész egy úgynevezett Verses fal formájában jelenik meg, ahol is bárki megoszthatja egy gondolatát vagy művét, mások pedig megnézhetik, elolvashatják, kedvelhetik.

Az eszközök a szerkesztőben kezelhetők. Egy műhöz több eszközt is hozzá lehet adni, amik figyelik a művet írás közben és értesítést küldenek, ha hibát találnak. Viszont nem minden eszköz küld értesítést. Például a leírás, szereplők listája.

# Felhasználói dokumentáció

## A program általános leírása

A progaram egy segéd eszközként és közösségi felületként szolgál a mai magyar íróknak, költőknek. Segít kapcsolatok szerzésében, ihlet keresésben és főként a zavartalan írásban. Ezeket a verses fallal és az írás közben támogató eszközökkel éri el. A programmal talán többen is kezdenek alkotni és mégtöbben csodálhatják a magyar nyelv szépségeit.

## Rendszerkövetelmények

### Hardver követelmények

- billentyűzet vagy bármilyen szövegbeviteli eszköz
- egér vagy bármilyen mutató eszköz
- minimum 800x600-as felbontású monitor vagy egyéb megjelenítő eszköz

### Szoftver követelmények

**Minimális követelmények:**
- dotNet keretrendszer 4.7.2-es verziója

**Ajánlott követelmények:**
- Windows 10 64bit-es változata
- internetkapcsolat

A program régebbi Windows rendszereken is (Windows 7, Windows 8 és 8.1) elfut, ami támogatja a megfelelő dotNet verziót, de nem ajánlott használni biztonsági okok miatt.

## Telepítés

A program telepítése nagyban hasonlít bármely másik program telepítéséhez. A telepítő megnyitása után a Next gombra kattintva a felhasználó kiválaszthatja, hogy hová szeretné telepíteni a programot és hogy csak magának vagy minden számítógépet használó embernek történjen a telepítés. A beállítás után 2 Next gomb után a program gyorsan települ és bezárható a telepítő.

Telepítés után a program parancsikonja megtalálható az asztalon.

## Program használata

### Profil kezelés (létrehozás, bejelentkezés, szerkesztés)

A program megnyitásakor (ha van internetkapcsolat) megjelenik a bejelentkező felület. Ha először van itt a felhasználó, regisztrálni is itt tud. Ezt az e-mail címe és egy jelszó beírása után, a regisztrálás gombra kattintva teheti meg. Ha minden rendben van, nem regisztráltak már a címmel és a jelszó is megfelelő, a program értesít a sikeres regisztrálásról, ezt követően be tud jelentkezni. Előfordulhat, hogy a felhasználó elfelejti a jelszavát. Ilyenkor az e-mail címe megadásával egy új, ideiglenes jelszót kérhet, amivel be tud jelentkezni. Egy véletlenszerűen generált jelszó található a kapott levélben, amit ajánlott megváltoztatni.

Az e-mail és jelszó kötelező adatok, de a főmenüben található Profil lap altt egy saját nevet és leírást is adhat meg a felhasználó. Ezen a lapon van lehetőség jelszó változtatásra is.

### Közösségi funkciók (mások megtalálása és verses fal)

A közösségi funkciók a főoldalon kezdődnek, ahol is az emberek egy keresőmező segítségével rátalálhatnak egymás profiljára. Egymás műveit nem lehet megnézni, csak amiket megosztottak a Verses falon.

A főmenüben a Verses fal lap alatt találjuk mások alkotásait és posztjait. Bárki megoszthat itt egy a szövegmezőbe írt üzenetet és a poszthoz akár egy művét is csatolhatja, amit mások olvashatnak. Itt a falon visszajelzésre is van lehetőség, kedvelések formájában.

Ha egy posztnál ott a Mű megtekintése gomb, a poszt írója egy művet csatolt ahhoz. Ha a felhasználó erre kattint, egy új ablak jelenik meg, amely 2 részből áll: egy olvasó felület, ahol a mű címe és maga az alkotás található és a részletek felülete, ahol pedig további adatok vannak, mint például a mű címkéje és hozzá tartozó eszközök (leírás, rím képlet, szereplők, stb.).

### Projekt kezelés (új, megnyitás, le-, feltöltés)

A főmenü következő eleme a Művek lap. Itt új verseket, regényeket kezdhet a felhasználó vagy tölthet be fájlból vagy az adatbázisból. Mind a három lehetőség a jobb alsó sarokban található.

Szerkesztés után a legutóbbi művek is ezen a lapon jelennek meg, így gyorsabban lehet folytatni a munkát. Ha közvetlen innen kattint a felhasználó egy műre, jobb oldalon megjelenik egy kis panel, ahol szerkesztés mellett itt tudja feltölteni a projektet a felhőbe.

A legutóbbi művekhez hozzáadni is lehet elemeket a programablak tetején lévő + gombbal. Ha egy projektet nem szeretne látni a felhasználó többet, minden kártyán van egy kis x gomb, amire kattintva el lehet távolítani a projektet a legutóbbiak közül vagy akár a számítőgépről.

### Mű írás (a szerkesztő és eszközök)

A mű szerkesztő felület egy szövegmezőből, egy oldal menüből és egy menü sávból áll. A szövegmezőbe írhat a felhasználó és itt jelenik meg egy felugró ablak a kurzornál, ha valami probléma van a szöveggel.

Az oldal menü első lapján a mű alap adatait lehet megadni. Cím, műfaj és itt található a készítés dátuma is. A második lapon az eszközök vannak. Egy gomb segítségével itt adhatunk hozzá új eszkózóket kategóriákból kiválasztva. Például a rímképlet a líra kategóriában van. Hozzáadás után a választott segítők kártyák formájában jelennek meg, ahol a felhasználó tölheti ezeket vagy módosíthatja a beállításokat. Minden eszköznek egyedi beállításai vannak, de a beállítások ablak tetején ott a leírás, ami a kiválasztott eszköz beállítását magyarázza.

Ha egy eszköz problémát észlel, azonnal felugrik a kurzornál a hiba lista, ahol minden műben talált probléma ott van. Ezt a listát a menüszalagon lévő gombbal és az F1 billentyűvel is előhívható.

A menüszalag első eleme a szokásos Fájl menüpont, amin belül lehet a projektet újrakezdeni, menteni, exportálni vagy egy másikat megnyitni.

### Támogatott formátumok és exportálás

A program több formátumot is támogat. Érdemes átgondolnia a felhasználónak, hogy mit használjon.

#### Egyszerű szöveg - *.txt

A legegyszerűbb formátum, amit bármelyik program könnyen olvashat. A mű után az eszközök is a fájlban vannak. Könnyű olvashatóság ellenére nem ajánlott a programon kívül így szerkeszteni a projektet.

#### Markdown - *.md

Egyszerű formázásokat támogató szöveges dokumentum. Ez lehetővé teszi, hogy a művekbe a felhasználók címeket, alcímeket, linkeket és idézeteket írhassanak. Könnyű olvashatóság ellenére ezt sem ajánlott a programon kívül szerkeszteni a projektet.

#### Bináris fájl - *.ikk

A program saját formátuma, amit csak ez tud olvasni, más program vagy ember nem. Ez a legbiztonságosabb formátum minden szempontból.

#### Weboldal - *.html

Művet nem lehet weboldalként menteni, csak exportálni. Ez azt jelenti, hogy az exportált művet nem lehet megnyitni a programban későbbi szerkesztésre. Ezért előtte mindenképp érdemes menteni.

A kész weboldalon minden külön HTML tag-ben van osztályokkal ellátva, hogy könnyen testreszabható legyen CSS-el.

### Értesítések

A programablak jobb alsó sarkában található egy gomb. A legtöbb esetben "Nincs új értesítés" feliratot viseli. Ha a felhasználó erre kattint, egy panelben ott látható az összes értesítés, ha van. Itt szerezhet tudomást a felhasználó például az internetkapcsolat állapotáról, ha offline módban van.

Az értesítések törölhetők és ha van funkciójuk, azok az értesítés lenyitása után elérhetők.

### Offline mód

A program induláskor ellenőrzi, hogy eléri-e az adatbázist. Ha ez nem sikerül, a program csak offline módban használható. Ilyenkor nem kell bejelentkezni és sok funkció elérhetetlenné válik. Viszont, amihez nem szükséges az adabázis, azok továbbra is használhatók. Ugyanúgy lehet projekteket írni, menteni, betölteni, az eszközöket kezelni.

Ha offline mód használata közben megjavul az internetkapcsolat, a program küld egy értesítést, hogy online módban is be lehet lépni.

# Fejlesztői dokumentáció

## Témaválasztás indoklása

Azért választottam egy költőknek, íróknak szóló programot, mert így szeretném támogatni őket, hogy alkossatok. Emellett jómagam is írok verseket.

A szoftver funkcióira is volt motivációm. A programozóknak vannak a legjobb eszközei, hisz magunknak csináljuk. Ezeknek legnagyobb részét az integrált fejlesztői környezetek képezik, ahol kód írás közben a környezet javít, segít.

Ezt a két dolgot kombináltam és így született meg az ötlet.

## Fejlesztői eszközök

### Visual Studio 2019

"*A Visual Studio a Microsoft több programozási nyelvet tartalmazó fejlesztőkörnyezete, amely az évek során egyre több új programnyelvvel bővült. Jelenleg a F#, C++, C# (ejtsd: Szí-sárp) és Visual Basic programozási nyelveket, valamint az XML-t támogatja. A csomag része még a MASM (Microsoft Macro Assembler) is, ami részleges assembly támogatást biztosít.*"

[https://hu.wikipedia.org/wiki/Microsoft_Visual_Studio](https://hu.wikipedia.org/wiki/Microsoft_Visual_Studio)

Ez a program volt maga az egyik motiváció az én programomhoz.

### XAMPP programcsomag

"*A XAMPP – (kiejtése: /ˈzæmp/ vagy /ˈɛks.æmp/) – egy szabad és nyílt forrású platformfüggetlen webszerver-szoftvercsomag, amelynek legfőbb alkotóelemei az Apache webszerver, a MariaDB (korábban a MySQL) adatbázis-kezelő, valamint a PHP és a Perl programozási nyelvek értelmezői (végrehajtó rendszerei). Ez a szoftvercsomag egy integrált rendszert alkot, amely webes alkalmazások készítését, tesztelését és futtatását célozza, és ehhez egy csomagban minden szükséges összetevőt tartalmaz. A rendszer egyik nagy előnye az összehangolt elemek könnyű telepíthetősége.*"

[https://hu.wikipedia.org/wiki/XAMPP](https://hu.wikipedia.org/wiki/XAMPP)

A XAMPP-ot az adatbázis teszteléséhez használtam és csak a teszteléshez. A felhasználók az interneten érik el az adatbázist.

### dbForge Studio

"*A dbForge Studio for MySQL egy univerzális GUI eszköz a MySQL és MariaDB adatbázis fejlesztéshez, menedzseléshez és adminisztrációhoz. Az IDE lehetővé teszi a lekérdezések létrehozását és végrehajtását, a tárolt rutinok fejlesztését és hibakeresését, az adatbázis-objektumok kezelésének automatizálását, az asztali adatok elemzését intuitív felületen keresztül. A MySQL kliens adatokat és séma összehasonlító és szinkronizálási eszközöket, adatbázis-jelentést készítő eszközöket, biztonsági mentési opciókat és ütemezést nyújt. -Broad kompatibilitási lehetőségek (MySQL, MariaDB szerver, Percona, Galera fürt, Amazon RDS, Amazon Aurora, Google Cloud, Alibaba Cloud, TokuDB, Sphinx, Tencent Cloud). -Az intelligens SQL kódolás (kód kitöltése, formázása, MySQL prompt és kódrészletek hoznak kényelmet és hatékonyságot az SQL kód íráshoz). Séma / adatok összehasonlítása és szinkronizálása. Adatgenerátor - támogatja az összes MySQL adattípust, tartalmaz számos értelmezhető generátort testreszabható beállításokkal, és lehetővé teszi az adatok generálását a parancssori felületen keresztül. Vizuális lekérdező készítő - vizuális lekérdezés létrehozása diagrammal és kifejezésszerkesztővel. Néhány másodperc alatt bármely összetettség lekérdezhető. A GUI eszköz automatikusan hozzáadja a táblák közötti csatlakozásokat, és lehetővé teszi az INSERT, UPDATE, DELETE utasítások használatát.*"

[http://hu.softoware.org/programming-software/download-dbforge-studio-for-mysql-for-windows-8-os.html](http://hu.softoware.org/programming-software/download-dbforge-studio-for-mysql-for-windows-8-os.html)

Mint a XAMPP-ot, ezt is az adatbázishoz használtam.

## Nyelvek

### dotNet C#

"*A C# (kiejtése: szí-sárp, de ismert a cisz elnevezés is) a Microsoft által a .NET keretrendszer részeként kifejlesztett objektumorientált programozási nyelv. A nyelv alapjául a C++ és a Java szolgált.*"

[https://hu.wikipedia.org/wiki/C_Sharp](https://hu.wikipedia.org/wiki/C_Sharp)

"*A Microsoft által készített .NET keretrendszer (a .NET Framework) gyors alkalmazásfejlesztést (RAD), platformfüggetlenséget és hálózati átlátszóságot támogató szoftverfejlesztői platform. A keretrendszert a korábbi platform, a COM leváltására szánták.*

*Eredetileg a .NET kifejezés nemcsak fejlesztői környezetet jelentett, hanem fejlesztőeszközök, szoftverek, sőt hardvereszközök összességét is. Az évek során a kép kitisztult, így mostanra a .NET alatt a keretrendszert értjük.*

*A .NET Framework eszköztára a szoftverfejlesztés szinte minden aspektusát (kliens-, illetve szerveroldali megoldások, adatbázisok kezelése, játékfejlesztés stb.) lefedi.*"

[https://hu.wikipedia.org/wiki/.NET_keretrendszer](https://hu.wikipedia.org/wiki/.NET_keretrendszer)

### MySQL

"*A szoftver eredeti fejlesztője a svéd MySQL AB cég, amely kettős licenceléssel tette elérhetővé a MySQL-t; választható módon vagy a GPL szabad szoftver licenc, vagy egy zárt (tulajdonosi) licenc érvényes a felhasználásra. 2008 januárjában a Sun felvásárolta 800 millió dollárért a céget. 2010. január 27-én a Sunt felvásárolta az Oracle Corporation, így a MySQL is az Oracle tulajdonába került.*

*A MySQL az egyik legelterjedtebb adatbázis-kezelő, aminek egyik oka lehet, hogy a teljesen nyílt forráskódú LAMP (Linux–Apache–MySQL–PHP) összeállítás részeként költséghatékony és egyszerűen beállítható megoldást ad dinamikus webhelyek szolgáltatására.*"

[https://hu.wikipedia.org/wiki/MySQL](https://hu.wikipedia.org/wiki/MySQL)

### HTML

"*A HTML (angolul: HyperText Markup Language=hiperszöveges jelölőnyelv) egy leíró nyelv, melyet weboldalak készítéséhez fejlesztettek ki, és mára már internetes szabvánnyá vált a W3C (World Wide Web Consortium) támogatásával. Az aktuális változata az 5, mely az SGML általános jelölőnyelv egy konkrét alkalmazása (azaz minden 5-ös HTML dokumentum egyben az SGML dokumentumszabványnak is meg kell hogy feleljen). Ezt tervek szerint lassan kiszorította volna az XHTML, amely a szintén SGML alapú XML leíró nyelven alapul.*"

[https://hu.wikipedia.org/wiki/HTML](https://hu.wikipedia.org/wiki/HTML)

A program csak az exportálás funkcióhoz használja ezt a nyelvet. Későbbiekben CSS-t is fog használni a program a nagyobb testreszabhatóság érdekében.

## Adatmodellek (táblák az adatbázisban)

**user** - Felhasználó

| Adat neve | Típus             | Leírás                                           | Null                     |
| --------- | ----------------- | ------------------------------------------------ | ------------------------ |
| id        | int               | egyedi azonosító                                 | kötelező mező            |
| email     | string / VARCHAR  | e-mail cím                                       | kötelező mező            |
| password  | string / CHAR(32) | jelszó titkosítva                                | kötelező mező            |
| name      | string / VARCHAR  | felhasználónév, alapértelmezetten az email eleje | kötelező mező            |
| about     | string / VARCHAR  | leírás / magamról                                | null érték engedélyezett |
| lastlogin | DateTime          | utolsó bejelentkezés ideje                       | null érték engedélyezett |

**project** - Projektek / művek

| Adat neve  | Típus            | Leírás             | Null          |
| ---------- | ---------------- | ------------------ | ------------- |
| id         | int              | egyedi azonosító   | kötelező mező |
| author     | int              | szerző azonosítója | kötelező mező |
| title      | string / VARCHAR | mű címe            | kötelező mező |
| content    | string / VARCHAR | tartalom           | kötelező mező |
| type       | string / VARCHAR | címke / műfaj      | kötelező mező |
| createdate | DateTime         | készítés dátuma    | kötelező mező |

**tool** - Projektekhez tartozó eszközök

| Adat neve | Típus            | Leírás             | Null          |
| --------- | ---------------- | ------------------ | ------------- |
| id        | int              | egyedi azonosító   | kötelező mező |
| project   | int              | mű azonosítója     | kötelező mező |
| name      | string / VARCHAR | eszköz neve        | kötelező mező |
| settings  | string / VARCHAR | eszköz beállításai | kötelező mező |

**post** - Poszt

| Adat neve | Típus            | Leírás                    | Null                     |
| --------- | ---------------- | ------------------------- | ------------------------ |
| id        | int              | egyedi azonosító          | kötelező mező            |
| time      | DateTime         | poszt ideje               | kötelező mező            |
| author    | int              | posztoló azonosítója      | kötelező mező            |
| text      | string / VARCHAR | szöveges tartalom         | kötelező mező            |
| project   | int              | megosztott mű azonosítója | null érték engedélyezett |

**post_like** - Csak egy kapcsolótábla, amin számon tartja kik kedvelték melyik posztot

| Adat neve | Típus | Leírás                  | Null          |
| --------- | ----- | ----------------------- | ------------- |
| id        | int   | egyedi azonosító        | kötelező mező |
| post      | int   | poszt azonosítója       | kötelező mező |
| user      | int   | felhasználó azonosítója | kötelező mező |

**quote** - Idézet

| Adat neve       | Típus            | Leírás                          | Null                     |
| --------------- | ---------------- | ------------------------------- | ------------------------ |
| id              | int              | egyedi azonosító                | kötelező mező            |
| quote           | string / VARCHAR | az idézet szövege               | kötelező mező            |
| author          | string / VARCHAR | az idézett személy              | kötelező mező            |
| category        | string / VARCHAR | kategória (jövőbeli funkcióhoz) | null érték engedélyezett |
| foreignlanguage | bool / int       | idegen nyelvű-e                 | kötelező mező            |
| contributor     | string / VARCHAR | beküldő (jövőbeli funkcióhoz)   | null érték engedélyezett |

## Részletes specifikáció, fontosabb algoritmusokés kódrészletek

// WORD

## Tesztelési dokumentáció

A program funkcióinak tesztelését és hibakeresést nem csak én, barátok, családtagok és osztálytársak is segítették, köztül egy költő is. Sok tanácsot és ötletet kértem tőlük, hogy mi az, ami támogatni tudná egy költő vagy egy író munkáját és ezeket bele is raktam a programba.

Vizsgálni főként a közösségi funkciókat kellett, hisz azokhoz több felhasználó szükséges. A posztolást, kedveléseket mind külső segítséggel igyekeztem hibáktól mentessé tenni.

## Továbbfejlesztési lehetőségek

### Napi idézetek

**Bővítés és beküldés**

Szeretném, ha az idézetek folyamatosan gyarapodnának, ezért lehetne a főoldalon egy funkció, amivel saját idézeteket írhatnak. Nem közvetlen az idézetes táblába, hanem egy olyan helyre kerülnének ezek először, ahol mások elfogadhatját vagy elutasíthatják az idézet javaslatokat.

**Testreszabhatóság szűrőkjel**

Az idézetekhez tartozik egy kategória is, szeretném ha e kategóriák segítségével a felhasználók kiszűrhetik a számukra megfelelő idézeteket. Például az angolul nem beszélők beállíthatják, hogy csak magyar idézetek jelenjenek meg.

### Közösségi funkciók

**Mások műveinek letöltése (ha engedi a poszt írója)**

Posztoláskor ha a felhasználó csatolt művet a poszthoz, legyen lehetősége, hogy mások számára a mű letölthető / elmenthető legyen. Ez a funkció hasznos lehet eszköz csomagoknál (erről később írok) vagy közösségi projekteknél.

**Komment szekció**

A posztok alá lehessen kommentet írni. Fontos, hogy ha egy költő megosztja egy versét, kaphasson visszajelzéseket és véleményeket az alkotásáról. Ezt a funkciót a komplexitása és a határidő miatt nem tudtam még megvalósítani, de elől van a prioritások között.

### Eszközök

#### Mégtöbb eszköz, mégtöbb segítség

Ötletek kategória szerint csoportosítva itt vannak leírva, bár a kategória nem jelent sokat, hisz bármilyen műhöz lehet bármilyen eszközt adni. Versnek is lehet epika kategóriába tartozó eszköze és regénynek is lehet szótagszám figyelője. A kevert műfajok miatt ez igen előnyös, mint például az elbeszélő költemény és a ballada.

**Általános eszközök**

- szinoníma szotár: figyeli a szóismétléseket és szinonímákat ajánl
- hangulat teremtő zene: Spotify kompatibilitás?
- ihlet adó kép csatolása
- clicker játék: easter egg formájában, alapból nincs az eszköz menüben

**Líra**

Főként a versekhez ajánlottak ezek az eszközök.

- szótag számláló
- képvers alkotó: átállítja a betűtípust monospace-re és segédvonalakat ad
- haiku bagy eszköz csoportok meglévő projektekbő: erről lejjebb még írok

**Epika**

Ide tartoznak a regények, novellák és bármilyen elbeszélés.

- szereplő lista
- helyszínek listája
- idővonal (esemény lista)
- körmondat figyelő: túl hosszú mondatoknál figyelmeztet

#### Eszköz csomagok / csoportok

Főleg verseknél vannak kötött formájú műfajok, például a haiku. Ilyenek alkotására jól jön, ha nem kellene a felhasználóknak egyesével hozzáadni és beállítgatni az eszközöket, hanem egy minta alapján egyszerre hozzáadni mindet. Haiku esetében lenne egy sok számláló, szótag számláló és egy rím figyelő. Regényeknél pedig hasznos, ha rögtön van egy szereplő-, helyszín lista és egy idővonal.

Ilyen eszköz csomagokat csinálhat majd a felhasználó is vagy másoktól is szerezhet be a Verses falon keresztül.

### Több exportálás lehetőség

**CSS használata szebb weboldalakhoz**

Jelenleg az exportálás funkció egyedül egy HTML fájlt generál. A legtöbb felhasználó nem szeretne CSS-el foglalkozni, hogy legyen a kész weboldalnak valamilyen kinézete, ezért előre elkészített CSS-ekből lehetne választani. Lehetne akár egy CSS állomány, amit a program a választott téma alapján készít el. Témákról később még írok.

**Mégtöbb formátum**

Szeretném, ha több lehetőség lenne az exportálásra és mégtöbb hasznos formátum lenne. Például a nyomtatás kedvéért a pdf formátum nagy cél, mert bármennyire fejlődik a technika, a papírnak még mindig van létjogosultsága.

### Téma motor

A programban már van egy működő téma motor, ami támogatja a dinamikus, futás közben történő változtatást. Egyszerűen csak a felhasználói felületen hiányoznak a beállítások. A motor jelenleg a háttér színt, az elsődleges színt, kiemelő színt és a szöveges elemek színét befolyásolja. A beállításokban a felhasználó ezeket mind tudná változtatni. Továbbfejlesztési ötletek közé tartozik, hogy ezeket a színeket el lehessen menteni témákba és a témákat lehessen szinkronizálni felhasználó alapján több eszköz között.

# Fejlesztési nehézségek

## Napi motiváló idézetek

Ha naponta szeretnék egy új idézetet mutatni a felhasználóknak, ahhoz sok adat kell és ha egy kész forrást használnék, az nem biztos, hogy minőségben elérné a megfelelő szintet. Egyedül kézzel válogatni sem lett volna túlságosan effektív, így másoktól kértem segítséget. Tanártól, baráttól, családtól kaptam főként így hamar összegyűlt annyi idézet, hogy több mint egy hónapig nem lát 2 ugyanolyant a felhasználó.

## Csatlakozás az adatbázishoz

Sajnos nem tanultunk egyetlen módszert sem, hogy hogyan tudunk asztali alkalmazásból adatbázisra csatlakozni, ezért magunknak kellett megoldani ezt a problémát. Szerencsére az interneten sokmindenre lehet megoldást találni, így hamar rátaláltunk a MySQLConnector nevű NuGet csomagra, ami az Oracle által fejlesztett NuGet csomag egy leszármazottja (fork-ja). Ezzel könnyen tudtunk csatlakozni adatbázisra és adatokat lekérni.

# Visszajelzések a tesztelőktől

"*Szerintem a program jó kezdést nyújt a kezdő költők / írók életében. Egy programon belül tudják megírni a művüket (legyen az egy vers, egy regény, vagy egy kisebb novella), ahelyett, hogy több különböző felületen folytatnák az írást, és a közzétételt is.*
 
*A napi idézetek meghozhatják az emberek kedvét, és sok eset még művelődnek is belőle. Az ikonok stílusosak, és jól használhatjuk őket úgy is, ha össze vannak kicsinyítve, mert a piktogramok jól utalnak az adott használatra (főoldal, profil, verses fal, művek). A betűtípus pedig nem túl csicsás, de nem is túl hagyományos. Kellemes a szemnek. A "Profil" részen jó ötlet, hogy magadról is írhatsz egy picit, ezáltal az olvasók nem csak az írást ismerhetik meg, hanem az írót is.*

*A "Főoldalon"-on pedig hasznosnak tartom a "Felhasználok keresése" pontot, főleg, ha egy konkrét emberre szeretnénk rákeresni.*
 
*Nagyon tetszik benne, hogy te magad választhatod ki, hogy milyen műalkotást szeretnél írni. Az írói felületen kifejezetten hasznosnak tartom az eszközöket. Véleményem szerint fontos, hogy így is tudja segíteni az alkalmazás az mű íróját. A lírai alkotásoknál használható sor számláló, ami szintén rengeteg segítséget tud nyújtani, főleg, ha egy hosszabb versben gondolkozunk. Ugyanezen résznél még találhatunk egy rím megfigyelőt, ami ugyancsak hasznossá válhat, ha elfelejtünk figyelni a sorok rímelésére. Emellett az "Általános" kifejezés alatt a "Leírás" gombra kattintva adhatunk egy rövid leírást a készített szerzeményről. Ha regényt írunk, ez főlegaz olvasók számára jöhet jól.*
 
*Kifejezetten támogatom az ötletet, hogy magában, az programon belül közzé lehessen tenni az alkotott remekművet, így többen is meg tudják tekinteni. Ezen kívül az olyan apróságok, mint a "Hiba lista", vagy a "Mű megnyitása fájlból" is egy nagyon hasznos funkcióként tud működni.*

*Még szívesen látnék benne esetleg olyant, hogy a felhasználók küldhessenek be napi idézeteket, és esetlegesen szinonímákkal is jó lenne segíteni az írókat az epikai mű írásnál.*"

# Források

// WORD
