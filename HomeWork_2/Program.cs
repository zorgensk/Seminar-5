// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void PrintArray(int[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}]");
    }
}

void RandomArray(int[] arr) // Метод заполнения массива случайными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}

int []arr = new int[5];
int sum = 0;
RandomArray(arr);
PrintArray(arr);
for(int i = 0; i < arr.Length; i+=2)
{
    sum += arr[i];
}
Console.WriteLine(" ");
Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях: {sum}");