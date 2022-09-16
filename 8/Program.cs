// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int MinSum(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minIndex = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum = sum + matr[m, n];
                minSum = minSum + matr[m, n]; 
            }
            else sum = sum + matr[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = m;
        }
        sum = 0;
    }
    return minIndex;
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
Console.WriteLine($"Строка с минимальной суммой под номером {MinSum(matrix)+1}");