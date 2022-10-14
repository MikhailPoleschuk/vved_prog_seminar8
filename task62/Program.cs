// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillArrayMatrix(int[,] AnyArray)
{
    int znachenie = 0;
    //1   
    int i = 0;
    int j = 0;
    while (j < AnyArray.GetLength(1))
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        //Console.WriteLine($"AnyArray[i, j]= {AnyArray[i, j]}");
        j++;
    }
    //2
    j = AnyArray.GetLength(1) - 1;
    i = 1;
    while (i < AnyArray.GetLength(0))
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        //Console.WriteLine($"AnyArray[i, j]= {AnyArray[i, j]}");
        i++;
    }
    //3
    i = AnyArray.GetLength(0) - 1;
    j = AnyArray.GetLength(1) - 2;
    while (j > -1)
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        //Console.WriteLine($"AnyArray[i, j]= {AnyArray[i, j]}");
        j--;
    }
    //4
    j = 0;
    i=AnyArray.GetLength(0) - 2;
    while (i > 0)
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        i--;
    }
    //5
    i = 1;
    j = 1;
    while (j < AnyArray.GetLength(1) - 1)
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        j++;
    }
    //6
    i = 2;
    j = AnyArray.GetLength(1) - 2;
    while (j > 0)
    {
        AnyArray[i, j] = znachenie + 1;
        znachenie++;
        j--;
    }
    

    return AnyArray;
}




void PrintArray(int[,] AnyArray)

{
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++) { Console.Write($"  {AnyArray[i, j]} "); }
        Console.WriteLine();
    }
}



int[,] newArray = new int[4, 4];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

