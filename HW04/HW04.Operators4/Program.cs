int number1;
int number2;
Console.WriteLine("Mathematical operations with numbers");

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

var result = 0;
string operators;

do
{
    Console.WriteLine("Input operator + or - or * or /");

    operators = Console.ReadLine();

    switch (operators)
    {
        case "+":
            result = number1 + number2;
            break;
        case "-":
            result = number2 - number1;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "/":
            result = number1 / number2;
            break;
        default:
            Console.WriteLine("Not supported operation");
            operators = string.Empty;
            break;
    }
}
while (string.IsNullOrEmpty(operators));

int result2;

Console.WriteLine("Input result calculations of numbers");

bool isResult2Correct;

do 
{
    isResult2Correct = int.TryParse(Console.ReadLine(), out result2);

    if (isResult2Correct)
    {
        if (result > result2)
        {
            Console.WriteLine("The result is wrong.");
            Console.WriteLine("Try again.");
            Console.WriteLine("Calculations of numbers should be more.");

        }
        else if (result < result2)
        {
            Console.WriteLine("The result is wrong.");
            Console.WriteLine("Try again.");
            Console.WriteLine("Calculations of numbers should be less.");
        }
        else
        {
            Console.WriteLine("Great! The result is correct.");
            Console.WriteLine("Calculations of numbers = " + result);
        }
    }
    else 
    {
        Console.WriteLine("Input an integer!");
    }
}
while (!isResult2Correct);

Console.ReadKey();