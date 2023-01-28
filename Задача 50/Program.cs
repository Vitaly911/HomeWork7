Console.WriteLine("Введите количество строк ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[str, col];
Console.WriteLine("Введите число от 0 до 10");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
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
void ElementCheck(int[,] mass)
{
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (number == mass[i, j])
            {
                count++;
                Console.WriteLine($"Элемент найден на позиции: [{i}, {j}] ");
            }
        }
    }
    if (count == 0) Console.WriteLine($"Элемент не найден");
}
RandomInteger(array);
ElementCheck(array);