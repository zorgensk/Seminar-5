// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

 void PrintArray(int[] arr) // Метод вывода массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"[{i}] = {arr[i]}");
    }
}

int [] num = {6, 2, 3, 4, 5, 7, 8, 12};

int lenght  = Convert.ToInt32(Math.Ceiling((double)num.Length/2));
int[] res = new int[lenght];

for(int i = 0; i < num.Length/2; i++)
{
    res[i] = num[i] * num[num.Length -1 - i];
}
 if(num.Length % 2 !=0)
 {
    res[lenght-1] = num[lenght-1];
 }
 PrintArray(res);

 