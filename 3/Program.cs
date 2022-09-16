// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(double[,] matr)
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

void FillArray(double[,] matr)
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

void Change(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i==j)
            {
            matr[i, j] = Math.Pow(matr[i, j], 2);
            }
        }
    }
}

Console.WriteLine("Введите размерность массива m*n");
Console.Write("Введите m: ");
int m  = int.Parse(Console.ReadLine());;
Console.Write("Введите n: ");
int n  = int.Parse(Console.ReadLine());;
double[,] matrix = new double[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Change(matrix);
PrintArray(matrix);