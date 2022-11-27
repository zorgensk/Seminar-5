// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void PrintArray(int[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}]");
    }
    Console.WriteLine(" ");
}

void RandomArray(int[] arr) // Метод заполнения массива случайными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}

int []arr = new int[5];

RandomArray(arr);
PrintArray(arr);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {arr.Max() - arr.Min()}");