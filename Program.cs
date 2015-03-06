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

            b.Sort(new ProductNameComparer());

            foreach (var i in b)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("--------------------");
            List<Product_CS2> c = Product_CS2.GetSampleProducts();
            foreach (var i in c)
            {
                Console.WriteLine(i.ToString());
            }

            Predicate<Product_CS2> test = delegate(Product_CS2 p)
            {
                return p.Price > 1000;
            };

            List<Product_CS2> ma = c.FindAll(test);

            Action<Product_CS2> print = Console.WriteLine;
            Console.WriteLine("--------------------");
            ma.ForEach(print);

            Console.WriteLine("--------------------");

            List<Product> d = Product.GetSampleProducts();
            d.Sort((x, y) => x.Name.CompareTo(y.Name));

            foreach (Product i in d)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------3----------");

            foreach (Product i in d.OrderBy(f => f.Price))
            {
                Console.WriteLine(i);
            }

            List<int> foo = new List<int>();
            foo.Add(15);
            foo.Add(12);
            foo.Add(15);
            foo.Add(3);
            foo.OrderBy(i => foo);

            foreach (int i in foo)
            {
                Console.WriteLine(i);
            }
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
            list.Add(new Product_CS1("111", 120));
            list.Add(new Product_CS1("ab", 120));
            list.Add(new Product_CS1("2222", 120));
            list.Add(new Product_CS1("3", 120));
            list.Add(new Product_CS1("44", 120));
            list.Add(new Product_CS1("777", 120));
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
            private set { price = value; }
        }
        public Product_CS2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product_CS2> GetSampleProducts()
        {
            List<Product_CS2> list = new List<Product_CS2>();

            list.Add(new Product_CS2("xxx", 120));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} , {1}", name, price);
        }
    }

    class Product
		{
			public string Name { get ; private set; }
			public decimal Price { get ; private set;  }

			public Product(string name , decimal price)
			{
				Name = name;
				Price = price;
			}

			public Product() { }

			public static List <Product> GetSampleProducts()
			{
                return new List<Product>
				{
					new Product { Name = "xxx", Price = 123 },
                    new Product { Name = "xxa", Price = 234 },
                    new Product { Name = "ff" , Price = 222},
				};
			}

			public override string ToString()
			{
				return string.Format("{0} , {1}", Name, Price);
			}
		}  
    class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        { 
            Product_CS1 first = (Product_CS1)x;
            Product_CS1 second = (Product_CS1)y;
            return first.Name.CompareTo(second.Name);
        }
    }   

}
