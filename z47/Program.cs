// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void InputM(double[, ]m)
{
    for (int i=0;i < m.GetLength(0);i++)
    {
        for (int j=0; j< m.GetLength(1);j++)
        {
        m[i, j] =new Random().NextDouble() * (10+10)-10;
        Console.Write($"{Math.Round(m[i, j],1)} \t");
        }
        Console.WriteLine();
    }
    
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] n = Console.ReadLine().Split(" ");
double[,] m = new double [int.Parse(n[0]), int.Parse(n[1])];
InputM(m);