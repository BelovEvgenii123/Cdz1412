// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

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

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] n = Console.ReadLine().Split(" ");
double[,] m = new double[int.Parse(n[0]), int.Parse(n[1])];
InputM(m);

Console.Write("Введите позицию: ");
string[] poz = Console.ReadLine().Split(" ");
if (int.Parse(poz[0]) >= m.GetLength(0) || int.Parse(poz[1]) >= m.GetLength(1))
    Console.WriteLine("такой позиции нет");
else

    Console.WriteLine(m[int.Parse(poz[0]), int.Parse(poz[1])]);

