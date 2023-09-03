// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 0  1  2  3   4  5  6   7
// 1, 2, 5, 7, 19, 6, 1, 33-> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" -> ");

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int min = minArr (" ");
int max = maxArr (" ");

int minArr (string minNum)
{
    Console.Write("Введите минимальное число массива: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int maxArr (string maxNum)
{
    Console.Write("Введите максимальное число массива: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] newArr = CreateArrayRndInt(8, min, max);
PrintArray(newArr);
