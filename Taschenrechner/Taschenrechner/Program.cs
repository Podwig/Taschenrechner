using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie die erste Zahl ein");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben sie bitte das Symbol an");
            string symbol = Console.ReadLine();
            Console.WriteLine("Geben sie die zweite Zahl ein");
            double input2 = double.Parse(Console.ReadLine());
            double Ergebnis = 0;
            
            if (symbol == "+")
            {
                Ergebnis = input1 + input2;
            }
            else if (symbol == "-")
            {
                Ergebnis = input1 - input2;
            }
            else if (symbol == "*" || symbol == "x")
            {
                Ergebnis = input1 * input2;
            }
            else if (symbol == "/" || symbol == ":")
            {
                Ergebnis = input1 / input2;
            }
            Console.WriteLine($"Das Ergebnis ist: {Ergebnis}.");
            Console.ReadLine();
        }
    }
}
