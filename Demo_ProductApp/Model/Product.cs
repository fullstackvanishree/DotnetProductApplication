using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ProductApp.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"Id::{Id}\t Name::{Name}\tPrice::{Price}\tCategoryId::{CategoryId}";
        }
    }
}
