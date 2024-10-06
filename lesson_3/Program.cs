using System;

namespace PrintFormatting
{

    class Formatting
    {
        static void Main(string[] args)
        {
            // print Console.Write formatting

            int k = 67;
            System.Console.WriteLine(k);

            // format

            System.Console.WriteLine($"Number : {k}");

            System.Console.WriteLine("Number k : {0}", k);

            System.Console.WriteLine("Number k : " + k);


        }
    }
}