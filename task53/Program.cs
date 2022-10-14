// 53
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

int[,] ReplaceFirstLineAndEndLineArray(int [,] AnyArray)
{
        int temp;
        int lastRows=AnyArray.GetLength(0)-1;
        for (int j = 0; j < AnyArray.GetLength(1); j++) 
        {
            temp = AnyArray[0,j];
            AnyArray[0,j]=AnyArray[lastRows,j];
            AnyArray[lastRows,j]=temp;
         }
        return AnyArray;
   
}

Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[rows, columns];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

int[,] newArray2=ReplaceFirstLineAndEndLineArray (newArray);
Console.WriteLine();
PrintArray(newArray2);

