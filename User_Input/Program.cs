using System;

namespace User_Inputs
{

    class UserInput
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("The is lesson User input Console");

            // User input string

            /* System.Console.Write("Enter your name : ");

             string name = Console.ReadLine();

             System.Console.WriteLine($"Your name is : {name}");
             */

            // input int parse function

            /*System.Console.Write("Enter your age : ");

            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Your age is : {age}");
            */

            /*
            System.Console.Write("Enter your age : ");

            int age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"Your age is : {age}");

            */

            System.Console.Write("Enter pi : ");

            //float pi = float.Parse(Console.ReadLine());
            float pi = Convert.ToSingle(Console.ReadLine());

            System.Console.WriteLine($"Pi is : {pi}");






        }
    }
}