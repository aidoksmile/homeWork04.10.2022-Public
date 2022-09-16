// Написать программу, которая обменивает элементы первой строки и последней строки

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

void Change(int[,] matr)
{
    int tmp = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        tmp = matr[0, j];
        matr[0, j] = matr[matr.GetLength(0)-1, j];
        matr[matr.GetLength(0)-1, j] = tmp;
    }
}

Console.WriteLine("Введите размерность массива m*n");
Console.Write("Введите m: ");
int m  = int.Parse(Console.ReadLine());;
Console.Write("Введите n: ");
int n  = int.Parse(Console.ReadLine());;
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Change(matrix);
PrintArray(matrix);