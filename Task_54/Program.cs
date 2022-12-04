// Задача 54: Задайте двумерный массив. Напишите метод, который упорядочит 
// по убыванию элементы каждой строки двумерного массива. И продемонстрируйте его работу.

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
int[,] arrayInArrangedOrder = ArrangeValuesInEachColumn(matrix);
Print2DArray(arrayInArrangedOrder);

// int[] result = Return1DArray(matrix);
// ArrangeValuesInColumn(result);
// PrintArray(result);

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
    for (int i = 0; i < matr.GetLength(0); i++) // возвращает кол-во строк в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++) // возвращает кол-во столбцов в массиве  
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrangeValuesInEachColumn(int[,] ma)
{
    for (int i = 0; i < ma.GetLength(0); i++)
    {
        for (int j = 0; j < ma.GetLength(1); j++)
        {
            for (int k = 0; k < ma.GetLength(1); k++)
            {
                if (ma[i, j] > ma[i, k])
                {
                    int temp = ma[i, j];
                    ma[i, j] = ma[i, k];
                    ma[i, k] = temp;
                }
            }
        }
    }
    return ma;
}













// int[] ArrangeValuesInColumn(int[,] ma)
// {
//     int[] newColumn = new int[n];
//     for (int i = 0; i < newColumn.Length; i++)
//     {
//         newColumn[i] = ma[0,i];
//     }
//     foreach (var i in newColumn)
//     {
//         Array.Sort(newColumn);
//         Array.Reverse(newColumn);
//     }
//     return newColumn;
// }

// int[] Return1DArray(int[,] mat)
// {
//     int[] newArray = new int[n];
//     for (int i = 0; i < mat.GetLength(1); i++)
//     {
//         newArray[i] = mat[0, i];
//     }
//     return newArray;
// }

// void ArrangeValuesInColumn(int[] arr)
// {
//     foreach (var i in arr)
//     {
//         Array.Sort(arr);
//         Array.Reverse(arr);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

