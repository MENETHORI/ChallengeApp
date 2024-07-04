string name = "Ewa";
string  sex = "kobieta";
// char = "m";
int age = 28;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}