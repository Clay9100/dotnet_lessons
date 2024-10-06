using System;

namespace Operators
{
    class Operator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The is lesson Operators info");

            // Add +

            int x = 2;
            int y = 3;

            int sum = x + y;

            Console.WriteLine($"({x} + {y}) = {sum}");

            // subtraction

            int a = 4;
            int b = 1;

            int subtraction = a - b;

            Console.WriteLine($"({a} - {b}) = {subtraction}");

            // division

            int q = 8;
            int w = 5;

            int division = q / w;

            Console.WriteLine($"({q} / {w}) = {division}");

            // multiplication

            int e = 6;
            int r = 3;

            int multiplication = e * r;

            Console.WriteLine($"({e} * {r}) = {multiplication}");

            // residual

            int t = 8;
            int u = 7;

            int residual = t % u;
            Console.WriteLine($"({t} % {u}) = {residual}");


        }
    }
}