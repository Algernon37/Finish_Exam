Console.WriteLine("Сколько эллементов в массиве будет?");
int a = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[a];
string[] array2 = new string[new Random().Next(0,4)];

void FullArray(string [] array)
{
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < a; i++)
{
   string name = Console.ReadLine();
   array [i] = name;
}
}

void RestartArray(string [] array2, string [] array1)
{
for (int i = 0; i < array2.Length; i++)
{
   array2 [i] = array1 [new Random().Next(0,array1.Length)];
}
}

void PrintArray(string [] array)
{
foreach (string i in array)
{
    Console.Write($"{i} ");
}
}

FullArray(array1);
RestartArray(array2, array1);
Console.WriteLine();
PrintArray(array2);
