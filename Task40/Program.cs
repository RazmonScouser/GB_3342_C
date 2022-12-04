// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("How many numbers would you like to enter");
int m = Convert.ToInt32(Console.ReadLine());
int Positivecount( int nums)
{
    int count = 0;
    for (int i = 0; i < m;i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) 
        {
            count++;
        }
    }
    return count;
}
int poscount = Positivecount(m);
if (poscount ==0)
{
    Console.WriteLine($"There are no positive numbers");
}
else if (poscount ==1)
{
    Console.WriteLine($"There is 1 positive number");
}
else
{
    Console.WriteLine($"There are {poscount} positive numbers");
}
