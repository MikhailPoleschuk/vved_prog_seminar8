// 59
int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = new Random().Next(0, 10); //можем регулировать в каком диапазоне создаются числа
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

int[] FindPositionMinMean(int[,] AnyArray)
{
    int min = AnyArray[0, 0];
    int minPosRows = 0, minPosColumns = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            if (AnyArray[i, j] < min)
            {
                minPosRows = i;
                minPosColumns = j;
                min = AnyArray[i, j];
            }
        }
    }
    int[] arrayMinPosRowsMinPosColumns = { minPosRows, minPosColumns };
    return arrayMinPosRowsMinPosColumns;
}

int[,] DelRowsAndColumns(int[,] AnyArray, int PosRows, int PosColumns)
{
    int newRows = AnyArray.GetLength(0) - 1;

    int newColumns = AnyArray.GetLength(1) - 1;

    int[,] cutArray = new int[newRows, newColumns];

    int countRows = 0;
    int countColumns = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        countColumns = 0;

        if (i != PosRows)
        {
            for (int j = 0; j < AnyArray.GetLength(1); j++)

            {
                if (j != PosColumns)
                {
                    cutArray[countRows, countColumns] = AnyArray[i, j];

                    countColumns++;

                }
            }
            countRows++;
        }


    }
    return cutArray;
}

Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[rows, columns];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

int[] MinPosRowsMinPosColumns = FindPositionMinMean(newArray);
Console.WriteLine($"Убираем строку {MinPosRowsMinPosColumns[0]+1} и столбец {MinPosRowsMinPosColumns[1]+1}");
int minPosRows = MinPosRowsMinPosColumns[0];
int minPosColumns = MinPosRowsMinPosColumns[1];

int[,] ResultArray = DelRowsAndColumns(newArray, minPosRows, minPosColumns);
PrintArray(ResultArray);


