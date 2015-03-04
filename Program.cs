using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MY_CS_CODE
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_CS1 a = new Product_CS1("a", 12);
            ArrayList b = Product_CS1.GetSampleProducts();

            foreach (var i in b)
            {
                Console.WriteLine(i.ToString());
            }

            //Product_CS2 c = new Product_CS2();

            List<Product_CS2> c = Product_CS2.GetSampleProducts();
            foreach (var i in c)
            {
                Console.WriteLine(i.ToString());
            }   
            Console.WriteLine(a.ToString());
            Console.ReadLine();
        }

       
    }

    class Product_CS1
    {
        string name;
        public string Name { get { return name; } }
        decimal price;
        public decimal Price { get { return price; } }

        public Product_CS1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product_CS1("xxx", 120));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, price);
        }
    }
    class Product_CS2
		{
			string name;
			public string Name
			{
				get { return name; }
				private set { name = value; }
			}

			decimal price;
			public decimal Price
			{
				get { return price; }
				private set { price = value ;}
			}
			public Product_CS2(string name, decimal price)
			{
				Name = name;
				Price = price;
			}

			public static List<Product_CS2> GetSampleProducts()
			{
				List<Product_CS2>list = new List <Product_CS2>();
                
				list.Add(new Product_CS2("xxx",120) );
				return list;
			}

			public override string ToString()
			{
				return string.Format("{0} , {1}", name , price);
			}	
		}
    
}
