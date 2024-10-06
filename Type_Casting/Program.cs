using System;

namespace TypeCasting
{
    class Types
    {

        static void Main(string[] args)
        {

            // type casting

            // int to double

            int x = 23;

            System.Console.WriteLine(x.GetType());

            double d = x;

            System.Console.WriteLine(d.GetType());

            // int to byte

            int i = 123;

            byte by = (byte)i;

            System.Console.WriteLine(by.GetType());

            // float to double

            float f = 3.14f;

            System.Console.WriteLine(f.GetType());

            double df = f;

            System.Console.WriteLine(df.GetType());


            // Convert function

            string s = "12";

            int si = Convert.ToInt32(s);

            System.Console.WriteLine(si.GetType());

            // string to char

            string sc = "@";

            char c = Convert.ToChar(sc);

            System.Console.WriteLine(c.GetType());

            // bool to int ture = 1 & false = 0;

            bool bl = true;

            int bi = Convert.ToInt32(bl);

            System.Console.WriteLine(bi.GetType());
            System.Console.WriteLine(bl);
            System.Console.WriteLine(bi);

            // Parse function

            string sp = "12345";

            int spi = int.Parse(sp);

            System.Console.WriteLine(spi.GetType());


           








        }
    }
}