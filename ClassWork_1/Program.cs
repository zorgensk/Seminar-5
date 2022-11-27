// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"[{i}] = {arr[i]}");
    }
}

int PositiveSum(int[] arr)
{
int sum = arr.Where(a => a > 0).Sum();
return sum;
}

int NegativeSum(int[] arr)
{
int sum = arr.Where(a => a < 0).Sum();
return sum;
}

int[] RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
    return arr;
}

int []num = new int[12];

RandomArray(num);
PrintArray(RandomArray(num));
Console.WriteLine($"Сумма положительных чисел: {PositiveSum(num)}\nСумма отрицательных чисел: {NegativeSum(num)}");
