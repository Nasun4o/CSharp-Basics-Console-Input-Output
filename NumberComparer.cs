using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Greater is: {0}", Math.Max(a, b));

        //  Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
    }
}

