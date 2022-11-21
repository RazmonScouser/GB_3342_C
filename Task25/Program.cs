// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.WriteLine("Enter a number and a degree");
int number1 = Convert.ToInt32(Console.ReadLine());
int degree1 = Convert.ToInt32(Console.ReadLine());
void Deg (int number, int degree)
{
    int count = 1;
    for (int i = 1; i <= degree; i++)
    {
        count = count*number;
    }
    Console.WriteLine(count);
}
Deg (number1,degree1);
    