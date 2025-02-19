using System.Runtime.CompilerServices;
using System;

namespace AdvancedCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write the beginning in cases a, s, m, d, exponent, sin, cos, tang, cotang, areas of different shapes
            //look up if you have to create a struct or a class
            //write the logic
            // double num1, num2
            // string op
            // a lot of if else statements (is there a better way?) 

            //figure out how to catch format exceptions, overflow and whatever else might come up
            //move this into Blazer, that might be cool to try and do.



            //make a switch statement that gives you the following options: 
            //do you want to do basic operations; calculate the area of a triangle; do trig; 

            Console.WriteLine("Welcome to my calculator!");
            Console.WriteLine("Please enter the corresponding integer. You can do the following:\n 1. Basic Arithmetic.\n 2. Calculate the area of a 2D shape.\n 3. Basic Trigonometry."); //this can probably be turned into a method

            int userChoice = Convert.ToInt32(Console.ReadLine());
            bool loop = true;
            while (loop)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Choose an operation based on its first letter e.g. `a` for addition, `m` for multiplication, etc.");
                        string basicOp = Console.ReadLine();
                        if (basicOp.ToLower().Equals("a"))
                        {
                            double result = Addition();
                            Console.WriteLine($"The result is: {result}");
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
                        //method; MOst likely, going to do the same for the areas and permiters of the shapes 
                        break;
                    case 3:

                        //method 
                        break;
                    default:
                        Console.WriteLine("Please enter a number corresponding to the action you wish to do.");
                        break;
                
                }
            

            }




        }
        //Useful Methods:

       
        public static double ReadNum(string s) //turns string to double
        {
            Console.WriteLine(s);
            return Convert.ToDouble(Console.ReadLine());
        }

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


        static double AreaOfIsoscelesTriangle(double baseOfTriangle, double height)
        {
            return (baseOfTriangle * height) / 2; 
        }

        static double AreaOfSquare(double side)
        {
            return side * side;
        }

        static double AreaOfRectangle(double side, double height)
        {
            return side * height;
        }
       

        

    
    }

}
