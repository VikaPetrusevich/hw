// Solution №1
using System.Text;

var stringBuilder = new StringBuilder();

Console.WriteLine("Solution №1.");

var text = "1a!2.3!!.. 4.!.?6 7! ..?";

Console.WriteLine($"Original string: {text}");

bool IsFirstCondition = true;

for (int i = 0; i < text.Length; i++)
{
    if (string.Equals(text[i].ToString(), "?", StringComparison.OrdinalIgnoreCase))
    {
        IsFirstCondition = false;
    }

    if (IsFirstCondition)
    {
        if (!string.Equals(text[i].ToString(), "!", StringComparison.OrdinalIgnoreCase) 
            && !string.Equals(text[i].ToString(), ".", StringComparison.OrdinalIgnoreCase))
        {
            stringBuilder.Append(text[i]);
        }
    }
    else
    {
        if (string.Equals(text[i].ToString(), " ", StringComparison.InvariantCultureIgnoreCase))
        {
            stringBuilder.Append('_');
        }
        else
        {
            stringBuilder.Append(text[i]);
        }
    }
   
}

Console.WriteLine($"\nChanged string: {stringBuilder.ToString()}");

// Solution №2

var text2 = "1a!2.3!!.. 4.!.?6 7! ..?";

Console.WriteLine("\nSolution №2.");

Console.WriteLine($"Original string: {text2}");

int symbol = text2.IndexOf('?');

Console.WriteLine("symbol={0}", symbol);

StringBuilder part1 = new StringBuilder(text2.Substring(0, symbol));

Console.WriteLine(part1);

StringBuilder part2 = new StringBuilder(text2.Substring(symbol));

Console.WriteLine(part2);

for (int i = 0; i < part1.Length; i++)
{
    if (string.Equals(part1[i].ToString(), "!", StringComparison.InvariantCultureIgnoreCase) 
        || string.Equals(part1[i].ToString(), ".", StringComparison.InvariantCultureIgnoreCase))
    {
        part1.Remove(i, 1);
        i--;
    }
}

part2.Replace(' ', '_');

text2 = part1.ToString() + part2.ToString();

Console.WriteLine("\nChanged string: " + text2);

Console.ReadKey();