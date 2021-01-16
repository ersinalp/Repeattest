using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claslar
{
    class Program
    {
        static void Main(string[] args)
        {



            string adi = "Engin";
            int yas = 32;

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 120000;
            kurs1.KursAdi = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Haluk Sevinen";
            kurs2.IzlenmeOrani = 1200;
            kurs2.KursAdi = "JAVA";


            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Ersin Alp  ";
            kurs3.IzlenmeOrani = 800;
            kurs3.KursAdi = "Pyhton";



            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Murat Kurtboğan ";
            kurs4.IzlenmeOrani = 800;
            kurs4.KursAdi = "C++";


            Kurs kurs5 = new Kurs();
            kurs5.PersonName = "Hakan";
            kurs5.PersonSurname = "Dumanlı";

            kurs5.IzlenmeOrani = 300;
            kurs5.KursAdi = "Alias";
            
            




            // Console.WriteLine(kurs1.KursAdi +"  "+kurs1.Egitmen +  "       İzlenme Oranı : "+kurs1.IzlenmeOrani );

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4,kurs5 };

            foreach (Kurs kurs in kurslar)
            {

                if (kurs.Egitmen==null)
                {
                    Console.WriteLine(kurs.KursAdi + "              " + kurs.PersonName+" "+kurs.PersonSurname);
                }
                else
                {

                    Console.WriteLine(kurs.KursAdi + "              " + kurs.Egitmen);
                    

                }



            }


            Console.ReadLine();


        }

        class Kurs:Person
        {
            

            public string  KursAdi       { get; set; }
            public string  Egitmen       { get; set; }
            public int     IzlenmeOrani  { get; set; }
      



        }

        class Person
        {

            public string PersonName { get; set; }
            public string PersonSurname { get; set; }


        }


    }
}
