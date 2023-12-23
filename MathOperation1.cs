using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation1
{
    class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one parameter optional by providing a default value
        public int mathOp1(int i, int j = 1)
        {
            //Perform multiplication on integers and return the result
            int num1 = i;
            int num2 = j;
            int result = i * j;
            return result;
        }
    }
}
