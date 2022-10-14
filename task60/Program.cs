// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArrayMatrix(int[,,] AnyArray)
{
   
   
    int[] tempArray = new int[89];
    int chislo = 10;
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = chislo;
        chislo++;
    }

    int znach = 0;
    int newPosition;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            for (int k = 0; k < AnyArray.GetLength(2); k++)
            {
                while (znach == 0)
                {
                    newPosition = new Random().Next(0, 89);
                    znach = tempArray[newPosition];
                    tempArray[newPosition] = 0;
                }
                AnyArray[i, j, k] = znach;
                znach = 0;
            }

        }
    }
    return AnyArray;
}

void PrintArray(int[,,] AnyArray)

{
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            for (int k = 0; k < AnyArray.GetLength(2); k++)
            {
                Console.Write($"{AnyArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}

int[,,] newArray = new int[2, 2, 2];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);