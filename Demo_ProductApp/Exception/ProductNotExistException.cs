using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ProductApp.Exception
{
    internal class ProductNotExistException:ApplicationException
    {
        public ProductNotExistException()
        {
            
        }
        public ProductNotExistException(string msg):base(msg) { }
        
    }
}
