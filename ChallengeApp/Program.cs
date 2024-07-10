using ChallengeApp;

Employee first = new Employee("Nowak", 23);
Employee second = new Employee("Kowalski", 24);
Employee third = new Employee("Sienkiewicz", 25);

first.AddScore(1);
second.AddScore(2);
third.AddScore(3);

first.AddScore(1);
second.AddScore(1);
third.AddScore(3);

first.AddScore(1);
second.AddScore(1);
third.AddScore(3);

int resultFirst = first.GetScore();
int resultSecond = second.GetScore();
int resultThird = third.GetScore();

if (resultFirst > resultSecond && resultFirst > resultThird)
{
    Console.WriteLine("Zwyciesca to " + first.Name + " Punktów " + resultFirst + " wiek " + first.Age);
}
else
{
    if (resultSecond > resultThird && resultSecond > resultFirst)
    {
        Console.WriteLine("Zwyciesca to " + second.Name + " Punktów " + resultSecond + " wiek " + second.Age);
    }
    else
    {
        Console.WriteLine("Zwyciesca to " + third.Name + " Punktów " + resultThird + " wiek " + third.Age);
    }
}
