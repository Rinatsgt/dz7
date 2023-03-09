// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    Console.WriteLine("Введите строки, а затем столбца: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a < matrix.GetLength(0) && b < matrix.GetLength(1))
    {
        Console.WriteLine($"Значение указанного Вами элемента: {matrix[a - 1, b - 1]}");
    }
    else
    {

        Console.WriteLine("Элемент указанный Вами отутствует в данной таблице, повторите ввод");
        if (int.TryParse(Console.ReadLine(), out a))
            if (int.TryParse(Console.ReadLine(), out b))
            {

            }

    }
}
int m = ReadInt("Введите количетсво строк: ");
int n = ReadInt("Введите количество столбцов: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
