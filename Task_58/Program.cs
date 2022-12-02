// Задача 58: Задайте две матрицы. Напишите метод, 
// который будет находить произведение двух матриц.

bool IsParsedM = int.TryParse(Console.ReadLine(), out int m);
bool IsParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsedM || !IsParsedN)
{
    Console.WriteLine("Error!");
    return;
}

int[,] matrix = new int[m, n];
int[,] anotherMatrix = new int[n, m];
FillMatrix(matrix);
FillMatrix(anotherMatrix);
Print2DArray(matrix);
Console.WriteLine();
Print2DArray(anotherMatrix);
Console.WriteLine();
int[,] multipleMatrix = MultiplyMatrixes(matrix, anotherMatrix);
Print2DArray(multipleMatrix);


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

int[,] MultiplyMatrixes(int[,] a, int[,] b)
{
    int[,] multipleMatrix = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            multipleMatrix[i, j] = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                multipleMatrix[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return multipleMatrix;
}