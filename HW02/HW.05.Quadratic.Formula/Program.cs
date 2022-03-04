// See https://aka.ms/new-console-template for more information
Console.WriteLine("Solution of a quadratic equation."); // решение квадратного уравнения
Console.WriteLine("Input a: ");
var a = Console.ReadLine();
var aAsNumber  = Convert.ToDouble(a);
Console.WriteLine("Input b: ");
var b = Console.ReadLine();
var bAsNumber = Convert.ToDouble(b);
Console.WriteLine("Input c: ");
var c = Console.ReadLine();
var cAsNumber = Convert.ToDouble(c);
double x1, x2;
// дискриминант
var discriminant = Math.Pow(bAsNumber, 2) - (4 * aAsNumber * cAsNumber);
if (discriminant < 0)
{
    Console.WriteLine("Quadratic equation hasn't roots"); //Квадратное уравнение не имеет корней
}
else
{
    if (discriminant == 0) // квадратное уравнение имеет 2 одинаковых корня
    {
        x1 = -bAsNumber / 2 * aAsNumber;
        x2 = x1;
        Console.WriteLine("Quadratic equation has two identical roots");
    }
    else // квадратное уравнение имеет 2 разных корня
    { 
        x1 = (-bAsNumber + Math.Sqrt(discriminant)) / (2 * aAsNumber);
        x2 = (-bAsNumber - Math.Sqrt(discriminant)) / (2 * aAsNumber);
        Console.WriteLine("Quadratic equation has two different roots");
    }
    // вывод корней уравнения
    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
}
Console.ReadKey();






