using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class SepetManager
    { 
        //naming convertion
        //syntax 

        public void Ekle(Urun urun) //method
        {
            Console.WriteLine("Tebrikler.  Sepete Eklendi ! {0} Stoğu :{1} " ,urun.Adi,urun.StokAdedi );
        }

        public void Ekleme_Operasyon(string urunadi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler.  Sepete Eklendi !  " + urunadi);
        }



    }
}
