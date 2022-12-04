// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Enter b and k arguments for the first function");
double b1 =Convert.ToDouble(Console.ReadLine());
double k1 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b and k arguments for the second function");
double b2 =Convert.ToDouble(Console.ReadLine());
double k2 =Convert.ToDouble(Console.ReadLine());

void Functions(double b, double k, double bb, double kk)
{
    if ((b==bb) && (k==kk))
    {
        Console.WriteLine("The graphics are aligned");
    }
    else if (k==kk)
    {
        Console.WriteLine("The graphics are parallel");
    }
    else
    {
        // y = k1*x+b1 y = k2*x+b2 => k1*x+b1 = k2*x+b2 => k1*x-k2*x = b2-b1 => x = (b2-b1)/(k1-k2)
        // y = k1*x+b1
        double x = (bb-b)/(k-kk);
        double y = k*x + b;
        Console.WriteLine($"({x};{y})");
    }   
}
Functions(b1,k1,b2,k2);