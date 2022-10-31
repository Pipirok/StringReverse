using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        // Task: Reverse a text string

        static string ReverseString(string input)
        {
            string output = "";

            // Iterate over all symbols in the array of reversed symbols in input string
            foreach (char c in input.Reverse().ToArray())
            {
                output += c;
            }
            return output;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }
    }
}
