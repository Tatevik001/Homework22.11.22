﻿// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

int[] numbers = new int[];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");
int Method(int a)
{
    return numbers[a];
}
