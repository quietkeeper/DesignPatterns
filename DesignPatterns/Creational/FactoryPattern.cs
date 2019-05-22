using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Factory//Factory method
    {
        public Product CreateProduct(string product)
        {
            Product p;
            switch(product){
                case "one":p=new ProductOne();
                    break;
                case "two": p = new ProductTwo();
                    break;
                default: p = new ProductOne();
                    break;
            }
            return p;
        }

       // public 
    }

    public abstract class Product
    {
        public abstract Product createProduct();
    }

    public class ProductOne : Product
    {
        public override ProductOne createProduct()
        {
            return new ProductOne();
        }
    }

    public class ProductTwo : Product
    {
        public override ProductOne createProduct()
        {
            return new ProductOne();
        }
    }

}
