Console.WriteLine("Input poem in one line, divide lines \";\".");

string text = Console.ReadLine().ToUpper();

text = text.Replace('О', 'А');

string[] poem = text.Split(';');

foreach (var item in poem)
{
    Console.WriteLine(item);
}

Console.ReadKey();

//Стихотворение в одну строку
//Я помню чудное мгновенье:;Передо мной явилась ты,;Как мимолетное виденье,;Как гений чистой красоты.