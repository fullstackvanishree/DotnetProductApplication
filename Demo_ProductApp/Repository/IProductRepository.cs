using Demo_ProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ProductApp.Repository
{
   public interface IProductRepository
    {
        List<Product>GetAllProducts();
        int AddProduct(Product product);
        //Product GetProductById(int productId);
    }
}
