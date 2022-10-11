// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

WriteLine("Введите размеры двумерного массива, максимальное и минимальное значение через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,] userArray = Create2dArray(parameters);
Print2dArray(userArray);

WriteLine();
WriteLine("Элементы строк упорядочены по убыванию:");
int[,] descArray=TwoDArrayRowsDescending(userArray);
Print2dArray(descArray);


int[,] TwoDArrayRowsDescending(int[,] inputArray)
{
    int[] tempArray = new int[inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            tempArray[j] = inputArray[i, j];
        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);
        for (int m = 0; m < inputArray.GetLength(1); m++)
        {
            inputArray[i, m] = tempArray[m];
        }

    }

    return inputArray;
}

int[,] Create2dArray(int[] param)
{
    int[,] createdArray = new int[param[0], param[1]];
    Random rnd = new Random();
    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            createdArray[i, j] = rnd.Next(param[2], param[3] + 1);
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