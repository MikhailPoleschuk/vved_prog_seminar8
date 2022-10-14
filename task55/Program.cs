// 55
int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = new Random().Next(-9, 10); //можем регулировать в каком диапазоне создаются числа
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

int[,] ReplaceRowsToColumns(int[,] AnyArray)
{
    int[,] newArray = new int[AnyArray.GetLength(0), AnyArray.GetLength(1)];
    int lastRows = AnyArray.GetLength(0) - 1;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
           newArray[i, j] = AnyArray[j, i];
            
        }
    }
    return newArray;

}

Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("Введите равное количество строк и столбцов");
}
else
{
    int[,] newArray = new int[rows, columns];
    newArray = FillArrayMatrix(newArray);
    PrintArray(newArray);
    Console.WriteLine();
    int[,] newArray2 = ReplaceRowsToColumns(newArray);
    PrintArray(newArray2);

}


