using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();
            dortIslem.Toplama(5, 6);
            dortIslem.Toplama(0, 16);
            dortIslem.Toplama(45,16);



            Console.ReadLine();
        }
       

    }
}
