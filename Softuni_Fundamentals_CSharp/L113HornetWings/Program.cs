using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L113HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double metersTraveled = (n / 1000) * m;
            Console.WriteLine($"{ metersTraveled:f2} m.");


            double flapsTime = ( n / 100 );
            double restTime = (n / p) * 5;
            double secondsPassed = flapsTime + restTime;
            Console.WriteLine($"{ secondsPassed} s.");

        }
    }
}
