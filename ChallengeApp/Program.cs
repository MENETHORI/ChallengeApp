List<string> deysOfWeek = new List<string>();
deysOfWeek.Add("poniedziałek");
deysOfWeek.Add("wtorek");
deysOfWeek.Add("środa");
deysOfWeek.Add("czwartek");
deysOfWeek.Add("piątek");
deysOfWeek.Add("sobota");
deysOfWeek.Add("niedziela");
deysOfWeek.Add("wolne");

//for (int i = 0; i<deysOfWeek.Count; i++)
//{
//    Console.WriteLine(deysOfWeek[i]);
//}
foreach (var day in deysOfWeek)
{
    Console.WriteLine(day);
}