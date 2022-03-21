Console.WriteLine("Input natural number from 1 to 100.");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
for (int i = 1; i <= number+1; i++)
{
    string x = new string(' ', i-1);
    Console.Write(x);
    for (int j = number+1; j > i; j--)
    { 
        Console.Write(" ");
        if (i < 10)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i%10);
        }
    }
   Console.WriteLine();
}

Console.ReadKey();
