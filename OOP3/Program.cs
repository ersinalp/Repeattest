using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreaditManager personelNeedCredit = new PersonelNeedCreditManager();       

            ICreaditManager vehicleCredit = new VehicleCreditManager();
        
            ICreaditManager mortgeCredit = new MortgeCreditManager();
            ICreaditManager Artisan = new ArtisanManager();

            ILoggerService loger = new DatabaseLoggerService();
            ILoggerService loger2 = new FileLoggerService();
            ILoggerService loger3 = new SmsLogger();

            List<ILoggerService> services = new List<ILoggerService>() { loger, loger2, loger3 };


            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.DoApplication(vehicleCredit,new DatabaseLoggerService()); // Başvuru yapılan müşteri . 

            applicationManager.DoApplication(Artisan,loger3,services );
            List<ICreaditManager> creadits = new List<ICreaditManager>() {personelNeedCredit,vehicleCredit }; // listeden iki kredi türü gönderilid. 
            //applicationManager.CreditPreIntermadiateDo(creadits);



            



            Console.Read();

        }
    }
}
