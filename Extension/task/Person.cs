using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Person
    {
        public int Id;
        private static int _id { get; set; }
        public string FullName { get; set; }
        public double Cash { get; set; }
        public sbyte Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (Age > 0)
                {
                    Age = value;
                }
            }
        }
        public Person()
        {
            _id++;
            _id = Id;
        }
        public override string ToString()
        {
            return $"Id:{Id},Adi:{FullName},Cash:{Cash},Yas:{Age}";
        }
    }
}
