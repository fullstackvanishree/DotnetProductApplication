using Demo_ProductApp.Exception;
using Demo_ProductApp.Model;
using Demo_ProductApp.Repository;

namespace Demo_ProductApp.Service
{
    internal class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public void GetAllProducts()
        {
            List<Product> allProducts = _productRepository.GetAllProducts();
            foreach (Product item in allProducts)
            {
                Console.WriteLine(item);
            }
        }

        //public void GetProductById()
        //{
        //    Console.WriteLine("Enter the ProductId");
        //    int productId = int.Parse(Console.ReadLine());
        //    Product searchProductStatus = _productRepository.GetProductById(productId);

        //    if (searchProductStatus != null)
        //    {
        //        Console.WriteLine(searchProductStatus);
        //    }
        //    else
        //    {
        //        throw new ProductNotExistException("productDoesnotexist");
        //    }


        //public List<Product> GetAllProducts()
        //{
        //   _productRepository.GetAllProducts();
        //}


        // }
    }
}

