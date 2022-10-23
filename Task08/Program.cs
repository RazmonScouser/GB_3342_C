// See https://aka.ms/new-console-template for more information
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
