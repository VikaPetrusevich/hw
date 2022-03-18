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
int result2;
Console.WriteLine("Input result sum of numbers");
while (!int.TryParse(Console.ReadLine(), out result2))
{
    Console.WriteLine("Input an integer!");
}
if (result == result2)
{
    Console.WriteLine("Great! The result is correct.");
    Console.WriteLine("Sum of numbers = " + result);
}
else 
{
    Console.WriteLine("The result is wrong.");
    Console.WriteLine("Try again.");
}
Console.ReadKey();