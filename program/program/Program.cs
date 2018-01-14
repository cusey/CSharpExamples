using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace program
{

    class Program
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
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

            Console.WriteLine("---2) GENERICS ---");

            var resultPrinter = new program.Generics.ResultPrinter();

            var result1 = new program.Generics.Result<String,int>{ Success = true, Data = "John", Action= 78};
            resultPrinter.Print(result1);

            var result2 = new program.Generics.Result<int,bool> { Success = true, Data = 5, Action=true };
            resultPrinter.Print(result2);

            Console.WriteLine("---3) ATTRIBUTES ---");

            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<program.Attributes.AttributeSample>().Count() > 0
                        select t;


            foreach (var t in types)
            {
                Console.WriteLine(t.Name);

                foreach(var p in t.GetRuntimeProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }

            Console.WriteLine("---4) REFLECTION ---");

            var assemblyRef = Assembly.GetCallingAssembly();
            Console.WriteLine(assemblyRef.FullName);

            var typesRef = assemblyRef.GetTypes();

            foreach (var t in types)
            {
                Console.WriteLine("Types: " + t.Name);

                var props = t.GetProperties();
                foreach( var p in props)
                {
                    Console.WriteLine("\t Property: " + p.Name + " Property Type : " + p.PropertyType);
                }

                var fields = t.GetFields();
                foreach( var f in fields)
                {
                    Console.WriteLine("\t Field: " + f.Name);
                }

                var methods = t.GetMethods();
                foreach (var m in methods)
                {
                    Console.WriteLine("\t Method: "  +m.Name);
                }
            }

            Console.WriteLine("---5) DELEGATES ---");

            program.Delegates.Square square = new program.Delegates.Square();

            // Crate an instance of the delegate, pointing to the logging function.
            // This delegate will then be passed to the Process() function.
            program.Delegates.Square.LogHandler myLogger = new program.Delegates.Square.LogHandler(Logger);
            square.Area(myLogger, 2);


            Console.ReadKey();
        }
    }
}
