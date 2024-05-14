using Demo_ProductApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ProductApp.BikeStoreApp
{
   
   
    internal class BikeStoreApplication
    {
        readonly IProductService _iproductService;
        public BikeStoreApplication()
        {
            _iproductService = new ProductService();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to Bike store!!!");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            Console.WriteLine("eneter your input");
            int userInput=int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1: _iproductService.GetAllProducts();
                    break;
                
                      
            }
        }
    }
}
