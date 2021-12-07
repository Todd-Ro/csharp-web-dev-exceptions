using System;

namespace ExceptionalPractice
{
    internal class Program
    {
        static void Main(string[] args) {


        Double[] temps = new double[] { };
        Double firstTemp;
        try
        {
            firstTemp = temps[0];
        }
        catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Value of firstTemp not set");
            }
    }
    }
}
