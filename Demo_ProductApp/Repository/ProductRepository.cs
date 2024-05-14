using Demo_ProductApp.Model;
using Demo_ProductApp.Utility;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Demo_ProductApp.Repository
{
    public class ProductRepository : IProductRepository
    {

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        //constructor
        public ProductRepository()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-0TE71RT;Database=BikeStore;Trusted_Connection=True");
            // sqlConnection=new SqlConnection(DbConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        #region using Block
        //public List<Product> GetAllProducts()
        //{
        //    List<Product> products = new List<Product>();
        //    using (SqlConnection sqlConnection = new SqlConnection(DbConnUtil.GetConnectionString()))
        //    {
        //        cmd.CommandText = "select * from Products";
        //        cmd.Connection = sqlConnection;
        //        sqlConnection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Product product = new Product();
        //            product.Id = (int)reader["Product_Id"];
        //            product.Name = (string)reader["Product_Name"];
        //            product.Price = (int)reader["Price"];
        //            product.CategoryId = (int)reader["Category_Id"];
        //            products.Add(product);
        //        }
        //    }


        //    return products;

        //}



        #endregion
        public List<Product> GetAllProducts()
        {
            //Create a list to hold the data from the database
            List<Product> products = new List<Product>();
            cmd.CommandText = "select * from Products";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = (int)reader["Product_Id"];
                product.Name = (string)reader["Product_Name"];
                product.Price = (int)reader["Price"];
                product.CategoryId = (int)reader["Category_Id"];
                products.Add(product);
            }
            return products;
            sqlConnection.Close();
        }

        //Add Product
        public int AddProduct(Product product)
        {
            //clearing parameters
            //cmd.Parameters.Clear()
            cmd.CommandText = "Insert into Products values(@Id,@Name,@Price,@catId)";
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("Name", product.Name);
            cmd.Parameters.AddWithValue("Price", product.Price);
            cmd.Parameters.AddWithValue("@catId", product.CategoryId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int addProductStatus = cmd.ExecuteNonQuery();
            return addProductStatus;

        }

        //public Product GetProductById(int productId)
        //{
        //    Product product = null;
        //    cmd.CommandText = "Select * from Products where Product_Id=@productId";
        //    cmd.Parameters.AddWithValue("@productId", productId);
        //    sqlConnection.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if(reader.Read())
        //    {
        //        product = new Product()
        //        {
        //            Id = (int)reader["Product_Id"];
        //        }

        //    }
        

        //}
    }
}
