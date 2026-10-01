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
