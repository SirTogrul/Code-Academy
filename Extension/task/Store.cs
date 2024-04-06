using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Store
    {
        public int Id;
        private int _id { get; set; }
        public Store()
        {
            _id++;
            _id = Id;
        }
        Product[] Products = new Product[0];
        public void AddProduct(Product Product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = Product;
        }
        public Product GetProduct(int id)
        {
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == id)
                {
                    return Products[i];
                }
            }
            return null;
        }
       public Product[] FilterProductsByType(string type)
        {
            Product[] ArrType= new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                  Array.Resize(ref  ArrType, Products.Length + 1);
                    ArrType[Products.Length - 1] = Products[i];

                }
            }
            return ArrType;
        }
        public Product[] FilterProductByName(string name)
        {
            Product[] ArrName= new Product[0];  
            for(int i=0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                  Array.Resize(ref ArrName, Products.Length + 1);
                    ArrName[Products.Length - 1] = (Product)Products[i];
                }
            }
            return ArrName;
        }
        public void Sale(int No, Person person)
        {
            Product product = GetProduct(No);
            if (product != null && product.Count > 0 && person.Cash >= product.Price)
            {
                product.Count--;
                person.Cash -= product.Price;
                Console.WriteLine("Mehsul satildi");
            }
            else
            {
                Console.WriteLine("satis ugursuz oldu");
            }
        }

        public void RemoveProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    for (int j = i; j < Products.Length - 1; j++)
                    {
                        Products[j] = Products[j + 1];
                    }
                    Array.Resize(ref Products, Products.Length - 1);
                    break;
                }
            }
        }
    }   
}
