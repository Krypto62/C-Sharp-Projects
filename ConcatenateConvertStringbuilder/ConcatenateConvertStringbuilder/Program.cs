using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateConvertStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string how = "By working hard, ";
            string length = "in record time.";
            
            Console.WriteLine("What is your name?");
            string userName = (Console.ReadLine());
            userName = userName.ToUpper();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(how + "you will complete this course " + length + " We want to tell you " + userName + ", Good Job!");
            Console.WriteLine("");
            Console.WriteLine("");
            StringBuilder sb = new StringBuilder("The fruitage of the spirit ", 50);
            
            sb.Append("is love, ");
            sb.Append("joy, ");
            sb.Append("peace, ");
            sb.Append("patience, ");
            sb.Append("kindness, ");
            sb.Append("goodness, ");
            sb.Append("mildness, ");
            sb.Append("and self-control.");
            sb.AppendLine();
            sb.Append("...Against such things there is no law.");
            
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
