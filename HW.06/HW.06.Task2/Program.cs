Console.WriteLine("Creating an array.");
int [] numbers = new int [10];
for (int i = 0; i < numbers.Length-1; i++)
{
    Console.WriteLine("Input a number: ");
    string text = Console.ReadLine();
    int num = Convert.ToInt32(text);
    numbers[i] = num;
}

Console.WriteLine("Read array.");

for (int i = 0; i < numbers.Length; i++)
{
   Console.Write (numbers[i] + " ");
}

Console.WriteLine(" ");

Console.WriteLine("Intup a number: ");

string text2 = Console.ReadLine();

int num2 = Convert.ToInt32(text2);

Console.WriteLine("Intup position in the arrray: ");

string text3 = Console.ReadLine(); 

int index = Convert.ToInt32(text3);

for (int i = index; i < numbers.Length; i++) 
{
    int temp = numbers[i];
    numbers[i] = num2;
    num2 = temp;
}

Console.WriteLine("Read changed array.");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.ReadKey();
