using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;

            sayi2 = 65;  // Sayi1 =30;

            //int, double,decimal, bool, uint, float ,bool =Değer tip 

            //Array, İnterface ,class =referans tip 



            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
           // sayilar1[0]=?    //999 olur 

            



        }
    }
}
