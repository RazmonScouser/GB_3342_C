//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Enter a three digit number");
int number = Convert.ToInt32(Console.ReadLine());
int second_digit = number % 100 / 10;
Console.WriteLine(second_digit);
