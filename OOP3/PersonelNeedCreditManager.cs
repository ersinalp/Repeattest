using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelNeedCreditManager : ICreaditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void CreditSucess()
        {
            throw new NotImplementedException();
        }
    }
}
