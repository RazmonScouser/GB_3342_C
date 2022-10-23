// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter two numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int min = number1; 
if (number1 < number2) {
min = number1;
}
else{
min = number2;
}
Console.WriteLine($"The minimum is {min}");