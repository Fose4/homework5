// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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


int EvenNumbers(int[] array)
{   
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[] arr = CreateArrayRndInt(4, 99,998);
PrintArray(arr);
int quantity = EvenNumbers(arr);
Console.WriteLine($" -->  {quantity}");