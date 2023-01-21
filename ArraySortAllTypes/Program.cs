/*Сортировка выбором*/

Console.Clear();
int[] array = new int[9];

// int[] array = { 7, 6, 3, 4, 5, 1, 2, 3 };

Console.WriteLine();
FillArray(array);
// PrintArray(array);
Console.WriteLine($"[{String.Join(',', array)}]");
Sort(array);

Console.WriteLine();
// PrintArray(result);

Console.WriteLine($"[{String.Join(',', array)}]");

void Sort(int[] array)
{ 
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[min] > array[j])
            {
                min = j;
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        Console.WriteLine($"[{String.Join(',', array)}]"); 
    }
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 21);
    }
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
