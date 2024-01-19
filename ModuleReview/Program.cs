using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

namespace ModuleReview
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a shape (circle, triangle, rectangle, square):");
            PickMe();





            //Console.WriteLine($"With the radius of {radius}, the area is {area}");




        }

        static double CircleArea(double radius)
        {
            if (radius > 0)
            {
                double area = Math.PI * Math.Pow(radius, 2);

                return area;
            }
            else
            {
                Console.WriteLine("Invalide input. Radius should be positive");
                return 0;
            }
        }

        static double TriangleArea(double baseLength, double hight)
        {

            if (baseLength > 0 && hight > 0)
            {
                return 0.5 * baseLength * hight;
            }
            else
            {
                Console.WriteLine("invalid input. basehight should be positive: ");
                return 0;
            }
        }

        static double RectangleArea(double lenght, double width)
        {

            if (lenght > 0 && width > 0)
            {
                return lenght * width;
            }
            else
            {
                Console.WriteLine("Invalid input. lenght should be positive");
                return 0;
            }


        }

        static double SquareArea(double lenght)
        {
            if (lenght > 0)
            {

                return lenght * lenght;
            }
            else


            {
                Console.WriteLine("invalid input. lenght should be positive");
                return 0;
            }
        }


        static string PickMe()
        {
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "circle":
                    Console.WriteLine("enter number for radius: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("area of circle is");
                    Console.WriteLine(CircleArea(num1));
                    break;
                case "triangle":
                    Console.WriteLine("enter numbers for base and hight: ");
                    double triNum1 = Convert.ToDouble(Console.ReadLine());
                    double triNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("area is ");
                    Console.WriteLine(TriangleArea(triNum1, triNum2 ));
                    break;
                case "rectangle":
                    Console.WriteLine("enter number for length and width: ");
                    double recNum1 = Convert.ToDouble(Console.ReadLine());
                    double recNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("area is");
                    Console.WriteLine(RectangleArea(recNum1, recNum2));
                    break;
                case "square":
                    Console.WriteLine("enter number for side: ");
                    double squNum1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("area is");
                    Console.WriteLine(SquareArea(squNum1));
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }

            return userAnswer;

        }

        
    }

    



    
}
