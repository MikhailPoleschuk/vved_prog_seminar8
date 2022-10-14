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

int[] array = {2,8,3,5,6,6,4,9};
for (int i=0;i<array.Length;i++) Console.Write(array[i]);
Console.WriteLine();

int[] arr2=SortLine(array);
for (int i=0;i<arr2.Length;i++) Console.Write(arr2[i]);

Console.WriteLine();
