// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();

WriteLine("Введите размеры первого двумерного массива, максимальное и минимальное значение через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,] userArray1 = Create2dArray(parameters);
Print2dArray(userArray1);
WriteLine();

WriteLine("Введите размеры второго двумерного массива, максимальное и минимальное значение через пробел: ");
int[] paramet = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,] userArray2 = Create2dArray(paramet);
Print2dArray(userArray2);


WriteLine();
int[,] multyply = MultiplyTwoMatrix(userArray1,userArray2);
Print2dArray(multyply);

int[,] MultiplyTwoMatrix(int[,] inputArray1, int[,] inputArray2)
{
    if(inputArray1.GetLength(1)!=inputArray2.GetLength(0))
    {
        WriteLine("Матрицы несовместимы");
    }
    int element =0;
    int[,] multyplyedArray = new int[inputArray2.GetLength(0),inputArray2.GetLength(1)];
    for (int i = 0; i < multyplyedArray.GetLength(0); i++)
    {
        for (int j = 0; j < multyplyedArray.GetLength(1); j++)
        {
            for (int k = 0; k < multyplyedArray.GetLength(0); k++)
            {
               element += inputArray1[i,k]*inputArray2[k,j];
            }
            multyplyedArray[i,j]=element;
            element=0;
        }
        

    }

    return multyplyedArray;
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