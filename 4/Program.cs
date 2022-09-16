// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,10);
            }
    }
}

void AverageSum(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum = sum + matr[j, i];
        }
        Console.WriteLine($"Среднее {i+1}-го столбца равно: {sum}");
    }
}

Console.WriteLine("Введите размерность массива m*n");
Console.Write("Введите m: ");
int m  = int.Parse(Console.ReadLine());;
Console.Write("Введите n: ");
int n  = int.Parse(Console.ReadLine());;
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
AverageSum(matrix);