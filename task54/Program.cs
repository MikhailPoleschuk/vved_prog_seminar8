// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[] SortLine(int[] AnyArray)
{
    int temp;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        for (int j = i + 1; j < AnyArray.Length; j++)
            if (AnyArray[i] < AnyArray[j])
            {
                temp = AnyArray[i];
                AnyArray[i] = AnyArray[j];
                AnyArray[j] = temp;
            };
    }
    return AnyArray;
}

int[,] ReplaceArray(int[,] AnyArray)
{
    int[] rows = new int[AnyArray.GetLength(1)];
    int[] sortRows = rows;

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++) { rows[j] = AnyArray[i, j]; }
        sortRows = SortLine(rows);
        for (int k = 0; k < AnyArray.GetLength(1); k++) { AnyArray[i, k] = sortRows[k] ; }
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

int[,] newArray2 = ReplaceArray(newArray);
Console.WriteLine();
PrintArray(newArray2);
