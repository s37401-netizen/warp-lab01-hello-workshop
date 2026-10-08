// 1
//Console.WriteLine("Cześć\nJestem Mykyta\nMój kierunek to informatyka\nChcę nauczyć się C#");
// 2
// string imie = "Mykyta";
// int wiek = 17;
// string gra = "Cs2";

// Console.WriteLine("+--------------------------+");
// Console.WriteLine("|\tWIZYTÓWKA\t");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"|\tImię: {imie}\t|");
// Console.WriteLine($"|\tWiek: {wiek}\t|");
// Console.WriteLine($"|\tGra: {gra}\t|");
// Console.WriteLine("+--------------------------+");
// 3
//Console.Write("Jak masz na imię? ");
//string imie = Console.ReadLine()!;
//Console.Write("Jaki jest Twój ulubiony kolor? ");
//string kolor = Console.ReadLine()!;
//Console.WriteLine($"\nCześć, {imie}! {kolor} to świetny kolor na płaszcz poszukiwacza przygód.");
//4
//int wiek = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Za rok będziesz miał {wiek + 1} lat, a za pięć {wiek + 5} lat");
//5
//Console.WriteLine("Ile kilometrów jest do celu: ");
//int cel = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Ile pokonujesz kilometrów na codzień: ");
//int speed = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Do celu tobie zostało {cel / speed} dni");
//6
//Console.WriteLine("Podaj liczbę monet złotych, srebrnych i miedzianych: ");
//int gold = int.Parse(Console.ReadLine()!);
//int silver = int.Parse(Console.ReadLine()!);
//int bronze = int.Parse(Console.ReadLine()!);

//Console.WriteLine($"{gold*100 + silver * 10 + bronze}");
//7
//int mikstura = int.Parse(Console.ReadLine()!);
//int krysztal = 3;
//int ziol = 2;
//Console.WriteLine($"Potrzebujesz {krysztal * mikstura} krzystałów oraz {ziol * mikstura} ziół");
//8
//decimal cenaNoclegu = decimal.Parse(Console.ReadLine()!);
//int nocy = int.Parse(Console.ReadLine()!);
//decimal cena = cenaNoclegu * nocy;
//Console.WriteLine(cena);
//9
//int liczbaSekund = int.Parse(Console.ReadLine()!);
//int minut = liczbaSekund / 60;
//int sekund = liczbaSekund % 60;
//Console.WriteLine($"{minut} minut {sekund} sekund");
//10
//int bohatery = int.Parse(Console.ReadLine()!);
//int monet = int.Parse(Console.ReadLine()!);
//int result = monet / bohatery;
//int rest = monet % bohatery;
//Console.WriteLine(result);
//Console.WriteLine(rest);
//11
//int obrazenieBroni = int.Parse(Console.ReadLine()!);
//int premiaDoSily = int.Parse(Console.ReadLine()!);
//int atakaZwykla = obrazenieBroni + premiaDoSily;
//int atakaSpecjalna = atakaZwykla * 2;
//int laczneObrazenia = (atakaZwykla * 3) + atakaSpecjalna;
//Console.WriteLine($"atakaZwykla: {atakaZwykla}");
//Console.WriteLine($"atakaSpecjalna: {atakaSpecjalna}");
//Console.WriteLine($"laczneObrazenia: {laczneObrazenia}");
//12
//string nazwaBohatera = Console.ReadLine()!;
//string nazwaKrainy = Console.ReadLine()!;
//int liczbaDni = int.Parse(Console.ReadLine()!);
//int liczbaPunktowDos = int.Parse(Console.ReadLine()!);
//int liczbaZlota = int.Parse(Console.ReadLine()!);

//int sredPunkt = liczbaPunktowDos / liczbaDni;
//int sredZlota = liczbaZlota / liczbaDni;

//Console.WriteLine("+--------------------------+");
//Console.WriteLine("|\tDziennik\t");
//Console.WriteLine("+--------------------------+");
//Console.WriteLine($"|\tImię: {nazwaBohatera}\t|");
//Console.WriteLine($"|\tKraina: {nazwaKrainy}\t|");
//Console.WriteLine($"|\tDni: {liczbaDni}\t|");
//Console.WriteLine($"|\tŚrednia PD: {sredPunkt}\t|");
//Console.WriteLine($"|\tŚrednia zł: {sredZlota}\t|");
//Console.WriteLine("+--------------------------+");
/*
Console.WriteLine("\t+=========================+\t");
Console.WriteLine("");
Console.WriteLine("\t|    DUNGEONS & GNOMES    |\t");
Console.WriteLine("");
Console.WriteLine("\t+=========================+\t");
Console.WriteLine("\n\n\n");
Console.Write("Nazwa Bohatera: ");
string name = Console.ReadLine()!;
string klasa = "unknown";
int HP = 100;
int sila = 12;
int zloto = 35;

Console.WriteLine("\t+========================+\t");
Console.WriteLine("");
Console.WriteLine("\t|    Hello Adventurer    |\t");
Console.WriteLine("");
Console.WriteLine("\t+========================+\t");
Console.WriteLine($"\t|\tBohater: {name}\t |\t");
Console.WriteLine($"\t|\tKlasa: {klasa}\t |\t");
Console.WriteLine("\t+------------------------+\t");
Console.WriteLine($"\t|\tHP: {HP}\t\t |");
Console.WriteLine($"\t|\tSiła: {sila}\t |\t");
Console.WriteLine($"\t|\tZłoto: {zloto}\t |\t");
Console.WriteLine("\t+------------------------+\t");
Console.WriteLine($"\t|\tłączna móc: {sila + HP}\t |\t");
Console.WriteLine("\t+========================+\t");
*/

// Lab2

//Zad1
/*string imie = "Mira";
char symb = '@';
int poziom = 2;
int zloto = 35;
double waga = 7.5;
bool maMape = true;

Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symb}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {waga} kg");
Console.WriteLine($"Ma mapę (bool): {maMape}\n");

zloto = 45;
poziom = 3;

Console.WriteLine("=== EKWIPUNEK ===");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symb}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {waga} kg");
Console.WriteLine($"Ma mapę (bool): {maMape}\n");
*/
//Zad 2
/*
int zloto = 50;
int dosw = 1;
int trening = 0;
dosw += 25;
Console.WriteLine($"Doświadczenie: {dosw}");
dosw *= 2;
Console.WriteLine($"Doświadczenie: {dosw}");
int WejscieNaArene = 8;
zloto -= WejscieNaArene;
Console.WriteLine($"Złoto: {zloto}");
int Nagroda = 15;
zloto += Nagroda;
Console.WriteLine($"Złoto: {zloto}");
trening =+ 1;
Console.WriteLine($"Liczba treningów: {trening}");
*/
//Zad 3
/*double racjiZ = double.Parse(Console.ReadLine()!);
int Czlonki = int.Parse(Console.ReadLine()!);
int DniW = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Każdy członek dostanie {(int)(racjiZ / Czlonki)} racji żywnościowych");
Console.WriteLine($"Zostanie {(int)(racjiZ % Czlonki)} racji żywnościowych po równym podziale");

double racjiDziennie = racjiZ / DniW;
double racjiDziennieOsoba = (racjiZ / Czlonki) / DniW;

Console.WriteLine($"Dzinnie przypadnie {racjiDziennie} racji żywnościowych");
Console.WriteLine($"Dzinnie przypadnie {racjiDziennieOsoba} racji żywnościowych na jedno osobe");
*/
//Zad 4
/*int Hp = int.Parse(Console.ReadLine()!);
int miks = int.Parse(Console.ReadLine()!);
bool maKlucz = bool.Parse(Console.ReadLine()!);
bool maMape = bool.Parse(Console.ReadLine()!);

bool zyje = Hp > 0;
bool maPelneZdrowie = Hp == 100;
bool wymagaLeczenia = Hp != 100;
bool maZaopatrzenie = miks >= 1;
bool maPrzedmiotNawigacyjny = maKlucz || maMape;
bool gotowyDoWyprawy = zyje && maZaopatrzenie & maPrzedmiotNawigacyjny;

Console.WriteLine("Żyje: " + zyje);
Console.WriteLine("Ma pełne zdrowie: " + maPelneZdrowie);
Console.WriteLine("Wymaga leczenia: " + wymagaLeczenia);
Console.WriteLine("Ma zaopatrzenie: " + maZaopatrzenie);
Console.WriteLine("Ma klucz lub mapę: " + maPrzedmiotNawigacyjny);
Console.WriteLine("Gotowy do wyprawy: " + gotowyDoWyprawy);
*/
//Zad 5
/*
string imie = Console.ReadLine()!;
int maxHp = int.Parse(Console.ReadLine()!);
int Hp = int.Parse(Console.ReadLine()!);
int ataka = int.Parse(Console.ReadLine()!);
int boostAtak = int.Parse(Console.ReadLine()!);
double mnoznikAtaku = double.Parse(Console.ReadLine()!);
int atakCount = int.Parse(Console.ReadLine()!);

int zwyklyAtak = ataka + boostAtak;
int specjalnyAtak = (int)(ataka * mnoznikAtaku);
int laczneObrazenia = zwyklyAtak * atakCount + specjalnyAtak;
double zdrowie = maxHp / Hp;
bool zyje = Hp >= 0;
bool maPelneZdrowie = Hp == maxHp;

Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {maxHp}/{Hp} ({zdrowie}%)");
Console.WriteLine($"Zwykły atak: {zwyklyAtak}");
Console.WriteLine($"Atak specjalny: {specjalnyAtak}");
Console.WriteLine($"Łączne zadanie obrażenia: {laczneObrazenia}");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine("====================================");
*/
// Zad 6
Console.WriteLine("Wpisz imię: ");
string imie = Console.ReadLine()!;
Console.WriteLine("Wpisz symbol: ");
char symb = char.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz Hp: ");
int Hp = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz MaxHp: ");
int MaxHp = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz Silę: ");
int sila = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz Zwykle obrażenia: ");
int zwykleObr = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz mnożnik ataku specjalnego: ");
double mnożnikAtakuSpec = double.Parse(Console.ReadLine()!);
int atakSpecjalny = (int)(zwykleObr * mnożnikAtakuSpec);
Console.WriteLine("Wpisz miejsce zajęte do 10: ");
int plecak = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz złoto: ");
int zloto = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz złoto: ");
int czlonki = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz ma mapę: ");
bool maMape = bool.Parse(Console.ReadLine()!);
bool zyje = Hp > 0;
bool maPelneZdrowie = MaxHp == Hp;
bool wymagaLeczenia = Hp < MaxHp;
bool maMiejsceWPlecaku = plecak != 10;
bool gotowyDoWyprawy = Hp > 0 && maMape && sila > 12;

Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.WriteLine($"|Bohater: {imie}                   {symb}  |");      
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"|Zdrowie: {Hp}/{MaxHp} ({(double)(MaxHp/Hp)})|");
Console.WriteLine($"|Siła: {sila}|");
Console.WriteLine($"|Zwykłe obrażenia: {zwykleObr}|");
Console.WriteLine($"|Mnożnik ataku specjalnego: {mnożnikAtakuSpec}|");
Console.WriteLine($"|Obrażenia ataku specjalnego: {atakSpecjalny}|");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"|Plecak: {plecak}|");
Console.WriteLine($"|Wolne miejsca: {plecak - 10}|");
Console.WriteLine($"|Złoto: {zloto}|");
Console.WriteLine($"|Liczba członków drużyny: {czlonki}|");
Console.WriteLine($"|Złoto dla jednej osoby: {czlonki / zloto}|");
Console.WriteLine($"|Złoto pozostające w skarbcu: {czlonki % zloto}|");
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"|Ma mapę: {maMape}|");
Console.WriteLine($"|Żyje: {zyje}|");
Console.WriteLine($"|Ma pełne zdrowie: {maPelneZdrowie}|");
Console.WriteLine($"|Wymaga leczenia: {wymagaLeczenia}|");
Console.WriteLine($"|Ma miejsce w plecaku: {plecak}|");
Console.WriteLine($"|Gotowy do wyprawy: {gotowyDoWyprawy}|");
Console.WriteLine("+==========================================+");
