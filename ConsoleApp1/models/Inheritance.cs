using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    internal class Inheritance : Acsses
    {
        public Inheritance(string name, string surname, int age) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            //_age = age;
        }
    }
}
