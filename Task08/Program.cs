// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter a limit number");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int even_factor=0;
while (count <= number)
{
    even_factor=count%2;
    if (even_factor==0)
    {
        Console.Write($"{count} ");
    }
    count++;
}
