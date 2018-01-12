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

            var result1 = new program.Generics.Result<String,int>{ Success = true, Data = "John", Action= 78};

            Console.Write("Result[ Success : {0}, Data : {1} , Action : {2} ] \n", result1.Success, result1.Data, result1.Action);

            var result2 = new program.Generics.Result<int,bool> { Success = true, Data = 5, Action=true };

            Console.Write("Result[ Success : {0}, Data : {1} , Action : {2} ] \n", result2.Success, result2.Data, result2.Action);







            Console.ReadKey();
        }
    }
}
