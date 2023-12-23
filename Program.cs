using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Instantiate MathOperation1 class
            //MathOperation1 mathOp1 = new MathOperation1();
            ////ask the user to provide first parameter
            //Console.WriteLine("Enter an integer: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            ////Ask the user to provide a second parameter or press enter
            //Console.WriteLine("Enter a second integer, or just press enter: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                //Call method with 2 parameters if both parameters are provided
                Console.WriteLine("Enter an integer");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second integer");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp1.MathOperation(num1, num2);
                Console.WriteLine(num1 + " * " + num2 + " = " + results);
            }
            catch 
            { 
                //Call method with one parameter if only one is provided
                int results = mathOp1.MathOperation("num1");
                Console.WriteLine("num1" + " * Default 1 = " + results);
            }
            Console.ReadLine();
        }
    }
}
