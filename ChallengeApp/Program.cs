// liczby całkowite
int myAge = 33;
int newAge = myAge + 1;
uint newUint = uint.MaxValue;

//liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

//zmienne tekstowe
string name = "Marcin";
string surename = "Grochowski";
string osoba = name + " "+ surename;
Console.WriteLine(osoba);
char myChar = 'd';
var result2 = name.ToArray();

//zmienne logiczne
bool isActive = true;

var number1 = 11;
var number2 = 10;

// && - i
// || - lub
// ! - nie

if (name == "adam" && myAge < 50)
{
    Console.WriteLine("Tak, to jest Adam");
}
else {
    Console.WriteLine("To jest "+ name );
}
