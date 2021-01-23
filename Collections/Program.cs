using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] adlar = new string[]
            //{
            //    "ENGİN",
            //    "MAHMUT",
            //    "ŞEVKİ",
            //    "TARIK"

            //};


            //Console.WriteLine(adlar[3]);

            //adlar = new string[5];
            //adlar[4] = "KASIM";
            //Console.WriteLine(adlar[4]);
            //Console.WriteLine(adlar[0]);

            //Console.Read();



            List<string> isimler = new List<string>() { "KASIM", "YASİN", "SÜLEYMAN","ERSİN" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İLKER");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            






            Console.Read();

            //List<T>


        }
    }
}
