// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

Console.WriteLine("Введите колличество строк матриц: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество рядов матриц: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[m, n];

Console.WriteLine("Заданы массивы: ");

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(0, 9);
        Console.Write($"{matrix1[i, j]} ");
    }
Console.WriteLine();
}

Console.WriteLine("и");

int[,] matrix2 = new int[m, n];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(0, 9);
        Console.Write($"{matrix2[i, j]} ");
    }
Console.WriteLine();
}

Console.WriteLine("Их произведение будет равно следующему массиву:");

int[,] matrix3 = new int[m, n];

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        int mult = 0;
        mult += matrix1[i,j] * matrix2[i,j];
        Console.Write($"{mult} ");
    }
    Console.WriteLine();
}
