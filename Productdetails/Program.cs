using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productdetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1= new Product(9001,"Apple","1Kg",199.00);
            p1 .ShowProduct();
            Product p2 = new Product(9002,"Mango","12pc",399.99);
            p2 .ShowProduct();
            
        }
    }
}
