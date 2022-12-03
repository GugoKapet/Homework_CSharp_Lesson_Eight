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
                int number = random.Next(1,10);
                if(CheckIfValueAlreadyExists(matrix, number) == true)
                {
                    matrix[i,j,k] = number;
                }
            }
        }
    }
}

bool CheckIfValueAlreadyExists(int[,,] ma, int random)
{
    bool result = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if(matrix[i, j, k] == random)
                {
                    return false;
                }
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}{(i,j,k)} ");
            }
        }
        Console.WriteLine();
    }
}