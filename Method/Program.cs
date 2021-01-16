using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        //Don't repeat yourself....  Clean code.. . Best practice 

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması ";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 50;
            urun3.Aciklama = "Diyarbakır Karpuzu";
            urun3.StokAdedi = 32;


            Urun[] urunler = new Urun[] { urun1, urun2,urun3 };




            // Type safe --- tip güvenliği 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(" Ürün Adı : {0}  Fiyatı .. :{1} Stoğu : {2}", urun.Adi, urun.Fiyati,urun.StokAdedi);
                Console.WriteLine(" -----------------------");


            }


            Console.WriteLine("----------------METHODLAR--------------------------");

            //instance 

            //encapsulation


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
       

            sepetManager.Ekleme_Operasyon("Greyfurt", "Kocaman iri iri", 12.5);

            sepetManager.Ekleme_Operasyon("Hurma", "İnce kabuk", 2.5);

            sepetManager.Ekleme_Operasyon("Ananas", "Ekvator malı", 22);


            Console.ReadLine();







        }
    }
}
