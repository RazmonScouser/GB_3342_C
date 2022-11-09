// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Enter a 5 digit number");
int number = Convert.ToInt32(Console.ReadLine());
int newnumber = 0;
void Palind(int number)
{
    if (number >= 10000 && number <= 99999)
    {
        int n1 = number / 10000;
        int n2 = number % 10000 / 1000;
        int n3 = number % 1000 / 100;
        int n4 = number % 100 / 10;
        int n5 = number % 10;
        newnumber = n5*10000 + n4*1000 + n3*100 + n2*10 +n1;
        if (number == newnumber)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("N0");
        }
    }
    else
    {
    Console.WriteLine("Error. Enter a 5 digit number");
    }
    
}
Palind(number);