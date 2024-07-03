string name = "Marcin";
string  sex = "mezczyzna";
// char = "m";
int age = 17;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age < 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    return;
}