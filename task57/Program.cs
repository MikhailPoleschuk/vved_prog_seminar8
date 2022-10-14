// 57
int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = new Random().Next(1, 4); //можем регулировать в каком диапазоне создаются числа
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

void Slovar(int[,] AnyArray)
{
    int count1 = 0, count2 = 0, count3 = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            if (AnyArray[i, j] == 1) count1++;
            else if (AnyArray[i, j] == 2) count2++;
            else if (AnyArray[i, j] == 3) count3++;
        }
    }
    if (count1 > 0) Console.WriteLine($"1 встречается {count1} раз");
    if (count1 > 1) Console.WriteLine($"2 встречается {count2} раз");
    if (count1 > 3) Console.WriteLine($"3 встречается {count3} раз");


}

Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[rows, columns];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

Slovar(newArray);