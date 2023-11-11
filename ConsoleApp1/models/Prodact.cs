using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Prodact
    {
        public string Name { get; set; }
        public string Category { get; set; }
        private double _price { get; set; }
        public int Count { get; set; }

        public Prodact(string name, string category, double price, int count)
        {
            Name = name;
            Category=category; 
            _price=price;
            Count=count;
        }

        public double Price 
        {
            get
            {
                if (_price <= 0)
                {
                    Console.WriteLine("set olmayib ");
                   
                }
                return _price;

            }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("Qiymet 0 ve daha az ola bilmez");
                    return;
                }
                _price = value;
                Console.WriteLine("set olundu");


            }
        }
    }

}
