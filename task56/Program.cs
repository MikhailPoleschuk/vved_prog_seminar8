// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int FindMinSummRowsOfArray(int[,] AnyArray)
{
    int summaRows=0;
    int numberMinSummaRows = 0;
    int i = 0;
    for (int j = 0; j < AnyArray.GetLength(1); j++)
    {
        summaRows = summaRows + AnyArray[i, j];
    }
    int minSummaRows = summaRows;

    for (i = 1; i < AnyArray.GetLength(0); i++)
    {
        summaRows = 0;
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            summaRows = summaRows + AnyArray[i, j];
        }
        if (summaRows < minSummaRows)
        {
            minSummaRows = summaRows;
            numberMinSummaRows = i;
        }

    }
    return numberMinSummaRows;
}



Console.Clear();
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[rows, columns];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

Console.WriteLine($"{FindMinSummRowsOfArray(newArray)+1} Строка");

