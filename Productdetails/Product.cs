using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productdetails
{
    internal class Product
    {
        int ProductId;
        string ProductName;
        string Quantity;
        double Price;
        public Product(int ProductId, string ProductName, string Quantity,double Price)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        public void ShowProduct()
        {
            Console.WriteLine(ProductId + " " + ProductName + " " + Quantity + " " + Price);
                  
        }
    }
}

