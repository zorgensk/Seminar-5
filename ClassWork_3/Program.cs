﻿// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int []num = {6, 7, 19, 345, 3};
int result = Array.IndexOf(num, 3);
if(result < 0) Console.WriteLine("заданного числа нет в массиве ");
    else
Console.WriteLine($"заданное число присутствует в массиве под индексом : {result}");