using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_4
{
    //1. Create a class. In that class, create a method that takes two integers
    //as parameters. Make one of them optional. Have the method do a math operation
    //and return a integer result.

    public class Stats
    {
        public int ERA(int num1, [Optional] int num2)
        {
        int num3 = 20;
        int calc = (num1 * num3) + num2;
        return calc;
        }
    }
}
