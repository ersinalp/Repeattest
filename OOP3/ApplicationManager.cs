using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {

        //Methot İnjection
        public void DoApplication(ICreaditManager creaditManager,ILoggerService loggerService,List<ILoggerService> loggers)
        {
            //Başvurulan bilgileri değerlendirme. 
            //Kredi hesaplama 

            // interfacleri birbirlerinin alternatifi 

            creaditManager.Calculate();
            loggerService.Log();

            foreach (var loger in loggers)
            {
                loger.Log();
            }





                                    
         }


        public void CreditPreIntermadiateDo(List<ICreaditManager> creadits)  // 1 tanede olabilir 1 den fazla da olabilir .
        {

            foreach (var credits in creadits)
            {
                credits.Calculate();

            }
                           



        }






    }
}
