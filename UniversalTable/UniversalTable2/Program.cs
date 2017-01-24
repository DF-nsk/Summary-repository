using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalTable2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public delegate double Fun(double x);

    abstract class TableFun
    {
        public abstract double F(double x);

        public void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine(new string('-', 20));
        }
    }
    class SimpleFun : TableFun
    {
        public override double F(double x)
        {
            return x * x;
        }
    }

    class SinFun : TableFun
    {
        public override double F(double x)
        {
            return Math.Sin(x);
        }
    }
}

