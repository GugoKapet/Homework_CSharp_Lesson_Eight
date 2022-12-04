// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] matrix = new int[2, 2, 2];
FillMatrix(matrix);
Print3DArray(matrix);
Console.WriteLine();


void FillMatrix(int[,,] matrix)
{

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int number = random.Next(10, 20);
                if (CheckIfValueAlreadyExists(matrix, number) == true)
                {
                    int number2 = random.Next(20, 30);
                    matrix[i, j, k] = number2;
                }
                else
                {
                    matrix[i, j, k] = number;
                }
            }
        }
    }
}

bool CheckIfValueAlreadyExists(int[,,] ma, int random)
{
    for (int i = 0; i < ma.GetLength(0); i++)
    {
        for (int j = 0; j < ma.GetLength(1); j++)
        {
            for (int k = 0; k < ma.GetLength(2); k++)
            {
                if (ma[i, j, k] == random)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]}{(i, j, k)} ");
            }
        }
        Console.WriteLine();
    }
}