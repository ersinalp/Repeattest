using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3; //stokta kaç kalmış 

          




            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5,UnitPrice=20, ProductName = "Kalem" };


            //Pascal Case  //camelcase (isimlendirme kuralları için geçerlidir.)
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool, ...... değer tip 
            //diziler , class, abstract class, interface  referans tip 
            //ref out keyword... 
            productManager.Topla2(3, 5);





            Console.ReadLine();



        }
    }
}
