Console.WriteLine("Введите количество строк ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, col];
void RandomInteger(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
void AverageNumber(int[,] mass)
{
    double AverageNumber = 0;
    double sum = 0;
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            sum = sum + mass[j, i];
        }
        AverageNumber = sum / mass.GetLength(0);
        Math.Round(AverageNumber, 2);
        Console.Write($"{AverageNumber}; ");
        sum = 0;
    }
}
RandomInteger(array);
AverageNumber(array);