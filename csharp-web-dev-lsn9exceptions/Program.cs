using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            double ratio;
            if (y != 0)
            {
                ratio = x / y;
                return ratio;
            }
            else
            {
                try
                {
                    ratio = x / y;
                    return ratio;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Cannot divide by 0 " +
                        "");
                    throw new ArgumentOutOfRangeException("y cannot be 0.");
                }
                return x;
            }
        }

        /*static int CheckFileExtension(string fileName)
        {
            // Write your code here!
        }
        */

        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


        }
    }
}
