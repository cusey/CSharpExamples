using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        public static int Data { get; private set; }
        public static bool Success { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(" *** C# Tutorial ***");

            Console.WriteLine("---1) CLASSES ---");

            program.Classes.Animal animal = new program.Classes.Animal("Spot", 9);

            Console.Write("Cat[ {0} ] \n", animal.ToString());

            animal.Age = -10;
            animal.Name = "Sam";

            Console.Write("Cat[ {0} ] \n", animal.ToString());

            Console.WriteLine("---1) GENERICS ---");

            var resultStr = new program.Generics.Result<String>{ Success = true, Data = "John"};

            Console.Write("Result[ {0}, {1} ] \n", resultStr.Success, resultStr.Data);

            var resultInt = new program.Generics.Result<int> { Success = true, Data = 5 };

            Console.Write("Result[ {0}, {1} ] \n", resultInt.Success, resultInt.Data);







            Console.ReadKey();
        }
    }
}
