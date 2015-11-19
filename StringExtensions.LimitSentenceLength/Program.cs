using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions.LimitSentenceLength
{
    class Program
    {
        private static string Paragraph => "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        static void Main(string[] args)
        {
            Console.WriteLine(Paragraph.LimitSentenceLength(50));
            //Lorem ipsum dolor sit amet, consectetur...
            Console.WriteLine(Paragraph.LimitSentenceLength(100));
            //Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut...
            Console.WriteLine(Paragraph.LimitSentenceLength(150));
            //Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam,...
            Console.WriteLine(Paragraph.LimitSentenceLength(200));
            //Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut...
        }
   
    }
}
