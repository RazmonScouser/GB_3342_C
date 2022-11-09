// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125
Console.WriteLine("Enter a number");
int number1 = Convert.ToInt32(Console.ReadLine());
void Cube(int number)
{
    if (number >= 1)
    {
        for (int i = 1;i <= number; i++)
        {
            Console.WriteLine($"{i} | {i*i*i}");
        }
    }
    else
    {
        Console.WriteLine("Enter a number bigger than 1");
    }
}
Cube(number1);