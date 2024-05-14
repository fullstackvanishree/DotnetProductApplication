using Demo_ProductApp.BikeStoreApp;
using Demo_ProductApp.Model;
using Demo_ProductApp.Repository;

namespace Demo_ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStoreApplication bikeStoreApplication=new BikeStoreApplication();
            bikeStoreApplication.Run();

           // IProductRepository productRepository = new ProductRepository();

           // List<Product>allProducts=productRepository.GetAllProducts();
           // foreach(Product item in allProducts)
           // {
           //     Console.WriteLine(item);
           // }

           // Product product = new Product() { Id = 100, Name = "TV", Price = 20000, CategoryId = 1 };
           //int addProductStatus= productRepository.AddProduct(product);
           // if (addProductStatus > 0)
           // {
           //     Console.WriteLine("Product Added Successfully");
           // }
           // else
           // {
           //     Console.WriteLine("Product addition Unsucessful");
           // }

        }
    }
}