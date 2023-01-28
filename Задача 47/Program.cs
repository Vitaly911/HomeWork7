Console.WriteLine("Введите количество строк ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[str, col];
void RandomFractionalNumber (double [,] mass)
{
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().NextDouble();
    }
}
}
void RandomInteger (double [,] mass)
{
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = mass[i, j] + new Random().Next(-9, 10);
        Math.Round(mass[i, j], 2);
        Console.Write($"{mass[i, j]} ");
    }
    Console.WriteLine();
}
}
RandomFractionalNumber(array);
RandomInteger(array);