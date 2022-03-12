Console.WriteLine("Intup the year and month of your birth YYYY.MM.");

DateTime birthday;
DateTime today;

while (!DateTime.TryParse(Console.ReadLine(), out birthday))
{
    Console.WriteLine("Input date of birthday!");
}

Console.WriteLine("Intup the year and month of today YYYY.MM.");

while (!DateTime.TryParse(Console.ReadLine(), out today))
{
    Console.WriteLine("Input the date of today!");
}

var months = (today.Month - birthday.Month) + 12 * (today.Year - birthday.Year);
var FullYears = months / 12;
Console.WriteLine("You are full years " + FullYears);

Console.ReadKey();