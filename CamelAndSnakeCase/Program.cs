using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelAndSnakeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var snake = "zostan_programista_dot_net";

            Console.WriteLine($"Wyrażenie zamienione na CamelCase: {snake}");
            Console.WriteLine($"Rezultat: {Camel.ToCamelCase(snake)}");

            Console.WriteLine();

            var camel = "zostanProgramistaDotNet";

            Console.WriteLine($"Wyrażenie zamienione na SnakeCase: {camel}");
            Console.WriteLine($"Rezultat: {Snake.ToSnakeCase(camel)}");

            Console.ReadLine();
        }
    }
}
