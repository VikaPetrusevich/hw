//Дана строка символов. Слова в строке отделяются друг от друга одним пробелом.
Console.WriteLine("Given a character string. Words in a string separated from each other by a single space");
Console.WriteLine("Возможность чему-то научиться нельзя упускать.");

string text = "Возможность чему-то научиться нельзя упускать";

//Удалить из строки самое длинное слово
DeleteLogestWord(text);

void DeleteLogestWord(string _text)
{
    var words = _text.Split(' ');

    var word = string.Empty;

    for (int i = 0; i < words.Length; i++)
    { 
      if (words[i].Length > word.Length)
        {
            word = words[i];
        }
    }
    var result = _text.Replace(word, string.Empty);

    Console.WriteLine("\nDelete longest word from string.");

    Console.WriteLine(result);
}

//Поменять местами самое длинное слово с самым коротким
ChangeWords(text);

void ChangeWords(string _text)
{
    var words = _text.Split(' ');

    var maxWord = string.Empty;
    var minWord = _text;

    var maxWordKey = "maxWord";
    var minWordKey = "minWord";

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length > maxWord.Length)
        {
            maxWord = words[i];
        }
        if (words[i].Length < minWord.Length)
        {
            minWord = words[i];
        }
    }
    var result2 = _text
        .Replace(maxWord, maxWordKey)
        .Replace(minWord, minWordKey)
        .Replace(maxWordKey, minWord)
        .Replace(minWordKey, maxWord);

    Console.WriteLine("\nChange words.");

    Console.WriteLine(result2);
}

//Посчитать сколько в строке букв, пунктуационных знаков
Console.WriteLine("\nCount how many letters, punctuation marks are in a string.");
Console.WriteLine("Если долго не напрягать мышцу, она атрофируется. Так же и с мозгом.");

string text2 = "Если долго не напрягать мышцу, она атрофируется. Так же и с мозгом.";

CountLettersPunctuation(text2);

void CountLettersPunctuation(string _text2)
{
    var punctuation = _text2.Count(char.IsPunctuation);
    var letters = _text2.Count(char.IsLetter);

    Console.WriteLine($"{letters} letters and {punctuation} punctuation are in a string.");
}

//Преобразовать строку в одномерный массив, используя пробел. Отсортировать массив по убыванию.
Console.WriteLine("\nConvert string to one dimensional array using space. Sort array descending.");

SortArrayDescending(text);

void SortArrayDescending(string _text)
{
    string[] line = _text.Split(' ');
    string temp;
    for (int i = 0; i < line.Length; i++)
    {
        for (int j = 0; j < line.Length-1-i; j++)
        {
            if (line[j].Length > line[j + 1].Length)
            {
                temp = line[j];
                line[j] = line[j + 1];
                line[j + 1] = temp;
            }
        }
    }

    for (int i = 0; i < line.Length; i++)
    {
        Console.WriteLine(line[i]);
    }
}

Console.ReadKey();
