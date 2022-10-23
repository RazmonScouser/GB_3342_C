// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter two numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int min = number1;
int max = number1; 
if (number1 < number2) {
min = number1;
}
else{
min = number2;
}
if (number1 > number2) {
max = number1;
}
else{
max = number2;
}
Console.WriteLine($"The minimum is {min}");
Console.WriteLine($"The maximum is {max}");