
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

WriteLine("Введите размеры трехмерного массива, максимальное и минимальное двузначное значение через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
WriteLine();
int[,,] userArray = Create3dArray(parameters);
Print3dArray(userArray);

WriteLine();





int[,,] Create3dArray(int[] param)
{
    int[] rand = new int[90];
    int z = 0;
    int[,,] createdArray = new int[param[0], param[1], param[2]];
    Random rnd = new Random();
    for (int i = 0; i < createdArray.GetLength(0); i++)
    {
        for (int j = 0; j < createdArray.GetLength(1); j++)
        {
            for (int k = 0; k < createdArray.GetLength(2); k++)
            {
                do
                {
                    createdArray[i, j, k] = rnd.Next(param[3], param[4] + 1);
                } while (Array.FindIndex(rand, el => el == createdArray[i, j, k]) > 0);
                rand[z] = createdArray[i, j, k];
                z++;

            }

        }
    }

    return createdArray;
}

void Print3dArray(int[,,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            for (int k = 0; k < printedArray.GetLength(2); k++)
            {
                Write($"{printedArray[i, j, k]}{(i, j, k)}\t");
            }
            WriteLine();
        }
        WriteLine();
    }
}
