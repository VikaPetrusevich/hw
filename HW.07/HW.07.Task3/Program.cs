//Введите строку, которая содержит числа в перемешку с символами.
//Данная строка должна содержать один математический символ: +, -, *, /.
Console.WriteLine("Input a string that contains numbers mixed with symbols" +
    ".This string must contain one mathematical symbol: +, -, *, /.");

string text = Console.ReadLine();

DoMathOperation(text);

void DoMathOperation(string? _text)
{
    var words = _text.Split('+', '-', '*','/');
    
    string[] numbers = new string[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        var word = words[i];
        for (int j = 0; j < word.Length; j++)
        {
            if ("0123456789".Contains(word[j]))
            {
                numbers[i] = numbers[i] + word[j];
            }
        }
    }
    
    int number1 = Convert.ToInt32(numbers[0]);
    int number2 = Convert.ToInt32(numbers[1]);
    int result = 0;

    switch (_text)
    {
        case var _  when  _text.Contains('+'):
            result = number1 + number2;
            break;
        case var _ when _text.Contains('-'):
            result = number1 - number2;
            break;
        case var _ when _text.Contains('*'):
            result = number1 * number2;
            break;
        case var _ when _text.Contains('/'):
            result = number1 / number2;
            break;
        default: Console.WriteLine("Operator not found.");
            break;
    }
    Console.WriteLine($"Result of a mathematical operation = {result}");
}
Console.ReadKey();