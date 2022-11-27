// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}]");
    }
}

void RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int []arr = new int[10];
RandomArray(arr);
int [] newarr = arr.Where(a => a % 2 == 0).ToArray();
Console.WriteLine($"Количество чётных чисел в массиве : {newarr.Length}");


