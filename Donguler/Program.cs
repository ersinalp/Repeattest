using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C#";


            //ARRAY de yani dizilerde tutarız. 

                  

            string[] kurslar = new string[]
        {
                "Yazılım Geliştirici Yetiştirme Kampı",
               "Programlamaya başlangıç için temel kurs",
                "Java","Python","C#"

        };

            for (int i = 0; i <kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

   


            Console.WriteLine("Sayfa sonu footer.");

           Console.ReadLine();



        }
    }
}
