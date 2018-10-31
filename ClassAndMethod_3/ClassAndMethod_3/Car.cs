using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod_3
{
        //1. Create a class. In that class, create a method that will take in an integer,
        //do a math operation to it and then return the answer as an integer.
    public class Car
    {
        public int Ford(int x)
        {
            int answer = 2018 + x;
            return answer;
        }
        //3. Add a second method to the class, with the same name,
        //that will take in a decimal, do a different math operation
        //to it and then return the answer as an integer.

        public int Ford(float y)
        {
            float answer2 = 65 - y;
            int answer3 = Convert.ToInt32(answer2);
            return answer3;
        }

        //5. Add a third method to the class, with the same name, that
        //will take in a string, convert it to an integer if possible, do a
        //different math operation to it and then return the answer as an integer.

        public int Ford(string z)
        {
            string reply = "Thank you. ";
            int answer = Convert.ToByte(z);
            int number = answer * 1;

            if (number == 0)
            {
                Console.WriteLine(reply + "Your car color is not white");
                return number;
            }
            else
            {
                Console.WriteLine(reply + "Your car color is white");
                return number;
            }
        }
    }
}
