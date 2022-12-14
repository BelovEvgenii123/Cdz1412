// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputM(double[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = new Random().Next(1, 11);
            Console.Write($"{m[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void Average(double[,] m)
{
    double sum = 0;
    for (int j = 0; j < m.GetLength(1); j++)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            sum += m[i, j];
        }
        Console.Write($"{Math.Round(sum / m.GetLength(0), 1)} \t ");
    }
}



Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] n = Console.ReadLine().Split(" ");
double[,] m = new double[int.Parse(n[0]), int.Parse(n[1])];
InputM(m);
Average(m);

