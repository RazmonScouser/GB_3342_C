// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int third_digit = number % 1000 / 100;
    Console.WriteLine(third_digit);
}
else 
{
    Console.WriteLine("There is no 3rd digit");
}


