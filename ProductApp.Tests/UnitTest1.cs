using Demo_ProductApp.Repository;
using Demo_ProductApp.Model;
namespace ProductApp.Tests
  
{
    public class Tests
    {
              

        [Test]
        public void TestToGetAllProducts()
        {
            //create an object of the Repository Layer
            ProductRepository productRepository = new ProductRepository();
            var allProducts=productRepository.GetAllProducts();
            Assert.That(8, Is.EqualTo(allProducts.Count));
        }

        public void TestToAddProduct()
        {
            ProductRepository productRepository = new ProductRepository();

            int addProductStatus=productRepository.AddProduct(new Product
            {
                Id = 20,
                Name = "TV",
                Price = 200,
                CategoryId=1
            });
            Assert.That(1, Is.EqualTo(addProductStatus));

        }
    }
}