using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        private int _count;
        public Product()
        {
            _count++;
            _count = Count;
        }
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                if (Price > 0) Price = value;
            }
        }
        public override string ToString()
        {
            return $"No:{No},Adi:{Name},Tipi:{Type},Qiymeti:{Price},Sayi:{Count}";
        }
    }
}
