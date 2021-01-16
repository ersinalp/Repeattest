using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeattest
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //type safety - tip güvenliği 
            //Do not repeat yourself - Kendini tekrarlama 

            var kategoriEtiketi = "Kategori";
            decimal sayi = 0;
            double faizOrani = 1.34;
            bool sistemeGirisYaptiMi = true;

            if (sistemeGirisYaptiMi==true)
            {
                Console.WriteLine("Kullancı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }










         Console.ReadLine();
        }



    }
}
