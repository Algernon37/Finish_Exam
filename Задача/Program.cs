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



FullArray(array1);

