// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using static System.Console;
Clear();

WriteLine("Введите размеры двумерного массива: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,] userArray = CreateSnail2DArray(parameters);
Print2dArray(userArray);

WriteLine();



int[,] CreateSnail2DArray(int[] param)
{
    int[,] createdArray = new int[param[0], param[1]];
    int rows = createdArray.GetLength(0);
    int columns = createdArray.GetLength(1);
    int currRow = 0;
    int currCol = 0;
    int k = 1;
    int r = 0;
    int c = 0;

    while (k <= rows * columns)
    {
        while (currCol < columns - c)
        {
            createdArray[currRow, currCol] = k;
            k++;
            currCol++;
        }
        k--;
        currCol--;
        while (currRow < rows - r)
        {
            createdArray[currRow, currCol] = k;
            k++;
            currRow++;
        }
        k--;
        currRow--;
        r++;
        while (currCol > c)
        {
            createdArray[currRow, currCol] = k;
            k++;
            currCol--;
        }
        c++;
        while (currRow > r)
        {
            createdArray[currRow, currCol] = k;
            k++;
            currRow--;
        }
    }


    return createdArray;
}





void Print2dArray(int[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Write($"{printedArray[i, j]}\t");
        }
        WriteLine();
    }
}