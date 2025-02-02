using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosYAGNI
{
    //your
    //not
    //gonna
    //need
    //it
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Product {name} added with price {price:C}");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Product with the {productId} deleted");
        }

    }

}

