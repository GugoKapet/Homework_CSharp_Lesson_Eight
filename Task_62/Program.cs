// Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.
Console.WriteLine("Введите значение, равное размерности массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] spiralArray = new int[n,n];
GetArrayInSpiralOrder(spiralArray);
Print2DArray(spiralArray);


void GetArrayInSpiralOrder(int[,] a)
// {
//     int startValue = 1;
//     for (int i = 1; i < n; i++)
//     {
//         for (int j = i - 1; j < n - i + 1; j++)
//         {
//             a[i - 1, j] = startValue++;
//         }
//         for (int j = i; j < n - i + 1; j++)
//         {
//             a[j, n - i] = startValue++;
//         }
//         for (int j = n - i - 1; j >= i - 1; j--)
//         {
//             a[n - i, j] = startValue++;
//         }
//         for (int j = n - i - 1; j >= i; j--)
//         {
//             a[j, i - 1] = startValue++;
//         }
//     }
// }
{
    int number = 1;
    for (int i = 0; i < n; i++)
    {
        a[0,i] = number++;
    }
    for (int j = 1; j < n; j++)
    {
        a[j,3] = number++;
    }
    for (int i = 2; i > 0; i--)
    {
        a[3,i] = number++;
    }
    for (int j = 3; j > 0; j--)    
    {
        a[j,0] = number++;
    }
    for (int i = 1; i < n-1; i++)
    {
        a[1,i] = number++;
    }
    for (int j = 2; j < n-1; j++)
    {
        a[j,2] = number++;
    }
    for (int i = 1; i > 0; i--)
    {
        a[2,i] = number++;
    }
}


void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", matr[i, j]));
        }
        Console.WriteLine();
    }
}