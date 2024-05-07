using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        delegate double Mydel(double r);
        event Mydel mdel;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Mydel myDel = LengthCircl;
            double rez = myDel(radius);
            Console.WriteLine($"L= {rez:f2}");

            myDel = AreaCircl;
            rez = myDel(radius);
            Console.WriteLine($"S= {rez:f2}");

            myDel = VolumeBall;
            rez = myDel(radius);
            Console.WriteLine($"V= {rez:f2}")

            Console.ReadKey();

        }

        static double LengthCircl(double r) => 2 * Math.PI * r;
        static double AreaCircl(double r) => Math.PI * r * r;
        static double VolumeBall(double r) => (4.0 / 3.0) * Math.PI * r * r * r;
    }
}
