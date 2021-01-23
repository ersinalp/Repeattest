using System;

namespace OOP2
{
    class Program
    {
        private static object realCustomer;

        static void Main(string[] args)
        {
            // Gerçek müşteri -- Tüzel Müşteri 
            //SOLID



            RealCustomer customer = new RealCustomer();
            customer.Id = 1;
            customer.CustomerNumber = 12345;
            customer.FirstName = "Ersin";
            customer.LastName = "Alp";
            customer.TcNo = "123456788990";



            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Creade Technology";
            customer2.CustomerNumber = 654543;
            customer2.TaxNumber = "1236543453";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();


            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(customer);
            customerManeger.Add(customer2);


            



        }
    }
}
