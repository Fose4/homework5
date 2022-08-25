﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateArrayRndInt( int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
int[] GetSumPosElem(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
       if (i % 2 != 1) sum = sum + array[i];
    }
    
    return new int[] { sum};
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CreateArrayRndInt(4, -100,99);
PrintArray(arr);
int[] sumNumber = GetSumPosElem(arr);
Console.WriteLine(string.Join(", ", sumNumber));
//  Console.Write($" -->  { sumNumber}");