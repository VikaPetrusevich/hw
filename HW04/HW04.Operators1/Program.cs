int number1;
int number2;
Console.WriteLine("Sum of numbers");
Console.WriteLine("Input an integer numder1: ");
while (!int.TryParse(Console.ReadLine(), out number1))
{
   Console.WriteLine("Input an integer!");
}
Console.WriteLine("Input the numder2: ");
while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Input an integer!");
}
int result = number1 + number2;
Console.WriteLine("Sum of numbers = " + result);
Console.ReadKey();