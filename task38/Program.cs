// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
double[] GetMaxMinElem(double[] array)
{
    double minNum =  array [0];
    double maxNum =  array [0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
        
    }
    double diff = maxNum - minNum;
    return new double[] { diff };
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}
double[] arr = CreateArrayRndInt(4, 0,99);
PrintArray(arr);

double[] maxMinElem = GetMaxMinElem(arr);
Console.Write(string.Join(",", maxMinElem));
//Console.WriteLine($"-> {maxMinElem}");
