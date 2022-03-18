Console.WriteLine("Game");
Console.WriteLine("Input W - move up.");
Console.WriteLine("Input S - move down.");
Console.WriteLine("Input A - move left.");
Console.WriteLine("Input D - move right.");
string result = Console.ReadLine().ToUpper();
switch (result)
{
    case "W": Console.WriteLine("You move up.");
        break;
    case "S": Console.WriteLine("You move down.");
        break;
    case "A": Console.WriteLine("You move left.");
        break;
    case "D": Console.WriteLine("You move right.");
        break;
    default: Console.WriteLine("You stend still.");
        break;
}
Console.ReadKey();