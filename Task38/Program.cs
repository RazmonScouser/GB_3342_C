// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
double [] arr = new double [10];

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length;i++ )
    {
        array[i] = new Random().Next(0,100) + new Random().NextDouble();
        Console.Write(array[i]);
        if (i != array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double DiffArray(double[] array )
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i =0; i< array.Length; i++)
    {
        if (array[i]<=min)
        {
            min = array[i];
        }
        if (array[i]>=max)
        {
            max = array[i];
        }
    }
    diff=(max-min);
    return diff;
}
PrintArray (arr);
Console.WriteLine(DiffArray(arr));