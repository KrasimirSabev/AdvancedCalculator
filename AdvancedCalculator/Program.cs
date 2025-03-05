using System.Runtime.CompilerServices;
using System;
using System.Reflection.Metadata;

namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //figure out how to catch format exceptions, overflow and whatever else might come up
            //move this into Blazer, that might be cool to try and do


            Console.WriteLine("Welcome to my calculator!");

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter the corresponding integer. You can do the following:\n 1. Basic Arithmetic.\n 2. Calculate the area of a 2D shape.\n 3. Basic Trigonometry."); //this can probably be turned into a method
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Choose an operation based on its first letter e.g. `a` for addition, `m` for multiplication, etc.");
                        string basicOp = Console.ReadLine();
                        if (basicOp.ToLower().Equals("a"))
                        {
                            double result = Addition();
                            Console.WriteLine($"The result is: {result}"); //I'm pretty sure that this can be optimised so I don't have to repeat this line so many times...
                        }
                        else if (basicOp.ToLower().Equals("s"))
                        {
                            double result = Subtraction();
                            Console.WriteLine($"The result is: {result}");
                        }
                        else if (basicOp.ToLower().Equals("m"))
                        {
                            double result = Multiplication();
                            Console.WriteLine($"The result is: {result}");
                        }
                        else if (basicOp.ToLower().Equals("d"))
                        {
                            double result = Division();
                            Console.WriteLine($"The result is: {result}");
                        }
                        else if (basicOp.ToLower().Equals("e"))
                        {
                            double result = Exponent();
                            Console.WriteLine($"The result is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Pick a number corresponding to the shape you want which perimeter or area you want to calculate:\n 1. Triangle,\n 2. Square,\n 3. Rectangle.");
                        int shape = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("To calculate the area press `a`. To calculate the perimeter, press anything else.");
                        string area = Console.ReadLine();
                        switch (shape)
                        {
                            case 1:
                                if (area.ToLower().Equals("a"))
                                {
                                    double result = AreaOfIsoscelesTriangle();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                else
                                {
                                    double result = PerimeterOfIsoscelesTriangle();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                break;
                            case 2:
                                if (area.ToLower().Equals("a"))
                                {
                                    double result = AreaOfSquare();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                else
                                {
                                    double result = PerimeterOfSquare();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                break;
                            case 3:
                                if (area.ToLower().Equals("a"))
                                {
                                    double result = AreaOfRectangle();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                else
                                {
                                    double result = PerimeterOfRectangle();
                                    Console.WriteLine($"The result is: {result}");
                                }
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Pick the corresponding number depending on the trigonometric function you want to calculate: \n 1.Sine \n 2.Cosine \n 3.Tangent \n 4.Cotangent");
                        int function = Convert.ToInt32(Console.ReadLine());
                        switch (function)
                        {
                            case 1:
                                double resultSin = SineFunction();
                                Console.WriteLine($"The result is: {resultSin}"); //this works but it doesn't tell you whether there are any solutions to such a function. 
                                break;
                            case 2:
                                double resultCosine = CosineFunction();
                                Console.WriteLine($"The result is: {resultCosine}");
                                break;
                            case 3:
                                double resultTangent = TangentFunction();
                                Console.WriteLine($"The result is: {resultTangent}");
                                break;
                            case 4:
                                double resultCotangent = CotangentFunction();
                                Console.WriteLine($"The result is: {resultCotangent}");
                                break;
                            default:
                                Console.WriteLine("Please enter a valid input.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a number corresponding to the action you wish to do.");
                        break;
                }
            }
        }
       
        //Read Input
        public static double ReadNum(string s) //turns string to double
        {
            Console.WriteLine(s);
            return Convert.ToDouble(Console.ReadLine());
        }

        //Basic Arithmetic Operations
        public static double Addition(double a=default, double b = default) 
        {
            a = ReadNum("Enter the first number: ");
            b = ReadNum("Enter the second number: ");
            return a + b;
        }

        public static double Subtraction(double a = default, double b = default)
        {
            a = ReadNum("Enter the first number: ");
            b = ReadNum("Enter the second number: ");
            return a - b;
        }

        static double Multiplication(double a = default, double b = default)
        {
            a = ReadNum("Enter the first number: ");
            b = ReadNum("Enter the second number: ");
            return a * b;
        }

        static double Division(double a = default, double b = default)
        {
            a = ReadNum("Enter the first number: ");
            b = ReadNum("Enter the second number: ");
            return a / b;
        }

        static double Exponent(double baseNum = default, double exponentNum = default)
        {
            //return Math.Pow(a, b); // this is the efficient way of doing it 
            baseNum = ReadNum("Enter the base number: ");
            exponentNum = ReadNum("Enter the base number: ");
            double result = 1;
            for (int i = 0; i < exponentNum; i++)
            {
                result *= baseNum; //multiply baseNum, result number of times
            }
            return result;
        }


        //Areas and Perimeters
        static double AreaOfIsoscelesTriangle(double baseOfTriangle = default, double height = default)
        {
            baseOfTriangle = ReadNum("Enter the base of the triangle: ");
            height = ReadNum("Enter the height of the triangle: ");
            return (baseOfTriangle * height) / 2; 
        }
        static double PerimeterOfIsoscelesTriangle(double a = default, double b = default)
        {
            a = ReadNum("Enter the side of the triangle: ");
            b = ReadNum("Enter the base of the triangle: ");
            return (2 * a) + b; 
        }

        static double AreaOfSquare(double side = default)
        {
            side = ReadNum("Enter the side of the square: ");
            return side * side;
        }

        static double PerimeterOfSquare (double side = default)
        {
            side = ReadNum("Enter the side of the square: ");
            return 4 * side; 
        }
        static double AreaOfRectangle(double side = default, double height = default)
        {
            side = ReadNum("Enter the side of the rectangle: ");
            height = ReadNum("Enter the other side of the rectangle: ");
            return side * height;
        }
        static double PerimeterOfRectangle(double a = default, double b = default)
        {
            a = ReadNum("Enter the side of the rectangle: ");
            b = ReadNum("Enter the other side of the rectangle: ");
            return (2 * a) + (2 * b); 
        }
       
       
        //Basic Trig
        static double SineFunction(double angle = default)
        {
            angle = ReadNum("Enter a specified angle to determine the sine function (in radians) of it: "); 

            return Math.Sin(angle); 
        }

        static double CosineFunction(double angle = default)
        {
            angle = ReadNum("Enter a specified angle to determine the cosine function (in radians) of it: ");

            return Math.Cos(angle);
        }

        static double TangentFunction(double angle = default)
        {
            angle = ReadNum("Enter a specified angle to determine the tangent function (in radians) of it: ");

            return Math.Tan(angle);
        }

        static double CotangentFunction(double angle = default)
        {
            angle = ReadNum("Enter a specified angle to determine the cotangent function (in radians) of it: ");

            return Math.Cos(angle) / Math.Sin(angle);
        }


    }

}
