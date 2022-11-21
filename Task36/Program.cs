// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] array =  new int [10];
int sumposuneven = 0;
Console.Write("[");
for (int i = 0; i < array.Length;i++ )
{
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i]);
    if (i != array.Length-1)
    {
        Console.Write(", ");
    }
    if (i % 2 ==0)
    {
        sumposuneven = sumposuneven + array[i];
    }
}
Console.WriteLine("]");
Console.WriteLine(sumposuneven);