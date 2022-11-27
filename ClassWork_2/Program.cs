// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

 void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
}

int[] RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
    }
    return arr;
}

int[] Maps(int[] x) 
  {
   return x.Select(e => e*-1).ToArray();
  }

int []num = new int[5];

PrintArray(RandomArray(num));

int [] newNum =Maps(num);

Console.Write(" -> ");
PrintArray(newNum);