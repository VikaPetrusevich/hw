Console.WriteLine("Creating arrays.");

int[] numbers = new int[5];

Random random = new Random();

for (int i = 0; i < numbers.Length; i++) 
{ 
    numbers[i] = random.Next(1, 100);
}

Console.WriteLine("Read array №1.");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine(" ");

int [] numbers2 = new int[5];

for (int i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine("Please, input a number: ");
    string text = Console.ReadLine(); 
    int num = Convert.ToInt32(text);
    numbers2[i] = num;
}

Console.WriteLine("Read array №2.");
for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] + " ");
}

Console.WriteLine(" ");

int [] numbers3 = new int[5];

Console.WriteLine("Result os sum of arrays.");

for (int i = 0; i < numbers3.Length; i++)
{
    numbers3[i] = numbers[i] + numbers2[i];
    Console.Write(numbers3[i] + " ");
}

Console.ReadKey();
