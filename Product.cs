using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class Product
    {
        private static List<Product> prod = new List<Product>();


        public int number { get; set; }
        public string date { get; set; }
        public int invnumb { get; set; }
        public string objname { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public void save()
        {
            Console.WriteLine("Saved");
            prod.Add(this);
        }
        public static List<Product> getall()
        {
            return prod;
        }
    }
}
