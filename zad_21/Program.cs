/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите кординату x точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние в 3d пространстве = "+ Distanse(x1,y1,z1,x2,z2,y2));


double Distanse (int a, int b, int c, int d, int f, int g)
{
double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
return dist;
}