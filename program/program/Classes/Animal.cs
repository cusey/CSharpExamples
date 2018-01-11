using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Classes
{
    public class Animal
    {
        private string name;
        private int age;

        public Animal(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
      
        public override string ToString()
        {
           return "Name : " + name + " Age : " + age;
        }


    }
}
