using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Acsses
    {
        public string Name { get; set; }
        protected string Surname { get; set; }
        private int _age { get; set; }

        public readonly string Position = "Student";

        public Acsses(string name,string surname, int age)
        {
            Name= name;
            Surname= surname;
            _age = age;
            Position = "test1";
        }

        public void Test()
        {
            //Position = "test";
            Console.WriteLine(Position);
        }
        public int Age 
        {
            get
            {
                if (_age < 0)
                {
                    Console.WriteLine("YAS 0 DAN KICIK OLA BILMEZ");
                
                }
                return _age;
            }
            set
            {
                if(value < 15) 
                {
                    Console.WriteLine("Giris qadagandir");
                    return;
                }
                else
                {
                    Console.WriteLine("GIRIS TESDIQLENDI");
                    _age = value;
                }
            } 
        }
    }

    
}
