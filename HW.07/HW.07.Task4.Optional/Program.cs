StreamReader textReader =
    new StreamReader(@"..\..\..\FindMe.txt", true);
string textReaderResult = textReader.ReadToEnd();
Console.WriteLine(textReaderResult);
var symbolArray = textReaderResult.ToCharArray();
for (int i = 0; i < symbolArray.Length; i++)
{
    if (char.IsControl(symbolArray[i]))
    {
        Console.WriteLine($"Index {i}");
        Console.WriteLine($"Вecimal character {((short)symbolArray[i])}");
    }
}

var control = symbolArray.Count(char.IsControl);
Console.WriteLine($"\nCount control symbol {control}");

textReader.Dispose();
