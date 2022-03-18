for (int i = 90; i >=65; i--)
{
    char symbol = (char)i;
    char symbol2 = (char)(i+32);
    Console.WriteLine($"{symbol} {symbol2}");
}
Console.ReadKey();