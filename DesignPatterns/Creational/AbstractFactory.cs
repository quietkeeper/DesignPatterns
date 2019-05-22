using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Factory
    {
        public virtual Product CreateProduct(string producttype);
    }

    public class FactoryA:Factory
    {
        public override Product CreateProduct(string producttype)
        {
            Product p = null; ;
            switch (producttype)
            { 
                case "One":
                    p = new ProductA1();
                    break;
                case "Two":
                    p = new ProductA2();
                    break;
                default:
                    p = new ProductA1();
                    break;
            }
            return p;
        }
    }
    public class FactoryB : Factory
    {
        public override Product CreateProduct(string producttype)
        {
            Product p = null; ;
            switch (producttype)
            {
                case "One":
                    p = new ProductB1();
                    break;
                case "Two":
                    p = new ProductB2();
                    break;
                default:
                    p = new ProductB1();
                    break;
            }
            return p;
        }
    }

    public abstract class ProductA:Product
    {
        public abstract Product createProduct();
    }

    public abstract class ProductB : Product
    {
        public abstract Product createProduct();
    }


    public class ProductA1 : ProductA
    {
        public override Product createProduct()
        {
            return new ProductA1();
        }
    }

    public class ProductA2 : ProductA
    {
        public override Product createProduct()
        {
            return new ProductA2();
        }
    }

    public class ProductB1 : ProductB
    {
        public override Product createProduct()
        {
            return new ProductB1();
        }
    }

    public class ProductB2 : ProductB
    {
        public override Product createProduct()
        {
            return new ProductB2();
        }
    }
}
