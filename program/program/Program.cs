﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** C# Tutorial ***");

            Console.WriteLine("---1) CLASSES ---");

            program.Classes.Animal cat = new program.Classes.Animal("Spot", 9);

            Console.Write("Cat[ {0} ] \n", cat.ToString());

            cat.Age = -10;
            cat.Name = "Sam";

            Console.Write("Cat[ {0} ] \n", cat.ToString());

            Console.ReadKey();
        }
    }
}