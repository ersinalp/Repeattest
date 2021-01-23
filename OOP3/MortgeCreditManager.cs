using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgeCreditManager : ICreaditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı");
        }

        public void CreditSucess()
        {
            throw new NotImplementedException();
        }
    }
}
