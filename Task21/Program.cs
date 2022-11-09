// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int xfirst, int yfirst, int zfirst, int xsecond, int ysecond, int zsecond)
{
    int RangeX = xsecond - xfirst;
    int RangeY = ysecond - yfirst;
    int RangeZ = zsecond - zfirst;
    double RangeCoord = Math.Sqrt(RangeX*RangeX + RangeY*RangeY + RangeZ*RangeZ);
    return RangeCoord;
}
double result = Range(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"The distance between point A({x1},{y1},{z1}) and point B({x2},{y2},{z2}) is {Math.Round(result,2)}");