using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            if (x>10)
            {
                x++;

            }
            else if (x<=5)
            {
                x = x % 5;
            }
            else
            {
                x = 1;
            }



            Console.WriteLine(x);


            Console.Read();
        }
    }
}
