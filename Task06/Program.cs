//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 
Console.WriteLine("Enter a number to know if it is even");
int number = Convert.ToInt32(Console.ReadLine());
int evenfactor = number % 2;
if (evenfactor == 0)  
{
    Console.WriteLine("Yes");
} 
else 
{
    Console.WriteLine("No");
};