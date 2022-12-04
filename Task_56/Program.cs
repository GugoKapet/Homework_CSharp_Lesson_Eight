// Задача 56: Задайте двумерный массив. Напишите метод, 
// который будет находить строку с наименьшей суммой элементов.

bool IsParsedM = int.TryParse(Console.ReadLine(), out int m);
bool IsParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsedM || !IsParsedN)
{
    Console.WriteLine("Error!");
    return;
}

int[,] matrix = new int[m, n];
FillMatrix(matrix);
Print2DArray(matrix);
Console.WriteLine();
int[] arrayOfSum = GetSumOfColumn(matrix);
PrintArray(arrayOfSum);
Console.WriteLine();
int[] valueOfMinColumn = FindMinColumnSum(arrayOfSum);
Console.Write($"Иднекс строки с минимальной суммой значений: {valueOfMinColumn[0]}, Сумма элементов данной строки: {valueOfMinColumn[1]} ");


void FillMatrix(int[,] m)
{
    Random random = new Random();
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i, j] = random.Next(1, 10);
        }
    }
}

void Print2DArray(int[,] matr)
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

int[] GetSumOfColumn(int[,] array)
{
    int[] arrayOfSum = new int[m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            arrayOfSum[i] = sum;
        }
    }
    return arrayOfSum;
}

int[] FindMinColumnSum(int[] a)
{
    int minValueOfColumn = a[0];
    int[] ArrayWithSumAndIndex = new int[2];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < minValueOfColumn)
        {
            minValueOfColumn = a[i];
            ArrayWithSumAndIndex[0] = i;
            ArrayWithSumAndIndex[1] = minValueOfColumn;
        }
    }
    return ArrayWithSumAndIndex;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}