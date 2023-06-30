Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
double [,] table = new double [n,n];
int sum = 0;
int sum1 = 0;
void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            sum = sum + 1;
            sum1 = sum1 + 1;
            matrix[0,columns] = sum;
            matrix[rows,0] = sum1;
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    } 
}
FillArray(table);
