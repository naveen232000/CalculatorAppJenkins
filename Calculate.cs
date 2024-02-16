using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculate
    {
        public void Add(double n1,double n2)
        {
            Console.WriteLine($"{n1} + {n2} = {(n1 + n2)}" );
        }
        public  void Sub(double n1, double n2)
        {
            Console.WriteLine($"{n1} - {n2} = {(n1 - n2)} " );
        }
        public  void Div(double n1, double n2)
        {
            Console.WriteLine($"{n1} / {n2} = {(n1 / n2)}" );
        }
        public  void Multi(double n1, double n2)
        {
            Console.WriteLine($"{n1} * {n2} = {(n1 * n2)}");
        }
    }
}
