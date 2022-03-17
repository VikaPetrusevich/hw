Console.WriteLine("Reverse array implementation.");
Random random = new Random();
int [] numbers = new int [10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = random.Next (0, 100);
}

Console.WriteLine("Read array.");

foreach (var item in numbers)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nReverse array.");

int [] numbers2 = new int [10];

for (int i = 0; i < numbers2.Length; i++)
{
    numbers2 [numbers2.Length-1-i] = numbers [i];
}

Console.WriteLine("Read reverse array.");

foreach (var item in numbers2)
{
    Console.Write(item + " ");
}

Console.ReadKey();
