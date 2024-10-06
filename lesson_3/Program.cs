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

            string str = $"Number str : {k}";
            System.Console.WriteLine(str);

            string name = "Simt";
            int age = 33;
            System.Console.WriteLine($"Your name is : {name} and age : {age} ");



        }
    }
}