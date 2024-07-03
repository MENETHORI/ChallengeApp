string imie = "Marcin";
string plec = "mezczyzna";
// char = "m";
int wiek = 17;

if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek < 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (plec == "mezczyzna" && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    return;
}