using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3VarsString
{
    class Program
    {
        static void Main(string[] args)
        {
            char myFirstChar = 'a'; // permite somente 1 caracte, allows only simple quota

            char exChar = (char)75; // ASCII Table to see all the char's and number relationship --> 75 = K
            Console.WriteLine(myFirstChar);
            Console.WriteLine(exChar);

            string myFirstString = "This is my first text in C#";

            Console.WriteLine(myFirstString); //string is the way to declarate string's vars in c#
            //using @ to consider the line breaks

            string howToConsiderLineBreaks = @"This is my
New Text
To show the line Break";
            Console.WriteLine(howToConsiderLineBreaks);
            Console.ReadLine();
        }
    }
}
