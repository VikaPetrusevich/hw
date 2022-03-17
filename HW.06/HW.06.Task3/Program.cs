// Реализация пользовательского Reverse массива
Console.WriteLine("Reverse array implementation.");
Random random = new Random();
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(0, 100);
}

Console.WriteLine("Read array.");

foreach (var item in numbers)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nReverse array.");

int[] numbers2 = new int[10];

for (int i = 0; i < numbers2.Length; i++)
{
    numbers2[numbers2.Length - 1 - i] = numbers[i];
}

Console.WriteLine("Read reverse array.");

foreach (var item in numbers2)
{
    Console.Write(item + " ");
}

Console.ReadKey();

// Измерение времени выполнения пользовательского Reverse массива

//using System.Diagnostics;

//Console.WriteLine("Reverse array implementation.");

//var timer = new Stopwatch();

//Random random = new Random();
//long[] numbers = new long[100_000_000];

//for (long i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(0, 100);
//}

//timer.Start();

//long[] numbers2 = new long[100_000_000];

//for (long i = 0; i < numbers2.Length; i++)
//{
//    numbers2[numbers2.Length - 1 - i] = numbers[i];
//}

//timer.Stop();

//Console.WriteLine($"Time custom reverse: {timer.ElapsedMilliseconds} milliseconds.");

//Console.ReadKey();

// Измерение времени выполнения оригинального Reverse метода

//using System.Diagnostics;

//Console.WriteLine("Reverse array implementation.");

//var timer2 = new Stopwatch();

//Random random = new Random();
//long[] numbers = new long[100_000_000];

//for (long i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(0, 100);
//}

//timer2.Start();

//Array.Reverse(numbers);

//timer2.Stop();

//Console.WriteLine($"Time array reverse: {timer2.ElapsedMilliseconds} milliseconds.");

//Console.ReadKey();
