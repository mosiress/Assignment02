using System;
namespace test02
{
class Program
{
static void Main(string[] args)
{
int a;
int b;
int c;
int d;
int e;
int f;
System.Console.WriteLine("Enter the values");
System.Console.WriteLine("a");
a = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("b");
b = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("c");
c = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("d");
d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("e");
e = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("f");
f = Convert.ToInt32(Console.ReadLine());
double D = (a*d) - (b*c);
double Dx = (e*d) - (b*f);
double x = Dx/D;
System.Console.WriteLine("x = " + x);
double Dy = (a*f) - (e*c);
double y = Dy/D;
System.Console.WriteLine("y = " + y);
if (a*d - b*c == 0)
System.Console.WriteLine("The equation has no solution");
}
}
}
