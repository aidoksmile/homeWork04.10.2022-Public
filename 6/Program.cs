// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void Sort(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, max])
                {
                    max = k;
                }
            }
            int tmp = matr[i, j];
            matr[i, j] = matr[i, max];
            matr[i, max] = tmp;
        }

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
Sort(matrix);
PrintArray(matrix);