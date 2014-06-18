//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose the method, that you want to use for calculating the surface:");
        Console.WriteLine("1: By given side and altitude to it");
        Console.WriteLine("2: By given three sides");
        Console.WriteLine("3: By given two sides and an angle between them");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)     //switch-case for the user's choice
        {
            case 1:
                {
                    SurfaceBySideAndAltitude();
                    break;
                }
            case 2:
                {
                    SurfaceByThreeSides();
                    break;
                }
            case 3:
                {
                    SurfaceByTwoSidesAndAngle();
                    break;
                }
            default:
                {
                    Console.WriteLine("Your input was invalid.");
                    break;
                }
        }
    }
    static void SurfaceBySideAndAltitude()
    {
        Console.Write("Please enter a side:");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Please enter the altitude to it:");
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of the triangle is: {0:F2}", side * altitude / 2);
    }
    static void SurfaceByThreeSides()
    {
        Console.Write("Please enter the first side: ");
        double sideOne = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second side:");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third side:");
        double sideThree = double.Parse(Console.ReadLine());
        double s = (sideOne + sideTwo + sideThree) / 2;
        Console.WriteLine("The surface of the triangle is: {0:F2}", Math.Sqrt(s * (s - sideOne) * (s - sideTwo) * (s - sideThree)));
    }
    static void SurfaceByTwoSidesAndAngle()
    {
        Console.Write("Please enter the first side: ");
        double sideOne = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second side: ");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.Write("Please enter the angle between them: ");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("The surface of the triangle is: {0:F2}", sideOne * sideTwo * Math.Sin(Math.PI * angle / 180) / 2);
    }
}
