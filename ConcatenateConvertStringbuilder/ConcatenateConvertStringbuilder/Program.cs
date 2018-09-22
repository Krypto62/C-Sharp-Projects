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
            //Concatenate three strings.
            string how = "By working hard, ";
            string length = "in record time.";
            
            Console.WriteLine("What is your name?");
            string userName = (Console.ReadLine());

            //Convert a string to uppercase.
            userName = userName.ToUpper();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(how + "you will complete this course " + length + " We want to tell you " + userName + ", Good Job!");
            Console.WriteLine("");
            Console.WriteLine("");

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
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
