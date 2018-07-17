using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how often do you hear a drop <in seconds>? ");
            string strDrip = Console.ReadLine();
            double dripTime = Convert.ToDouble(strDrip);
            Console.WriteLine("This Wastes " + 3600 / dripTime * 0.00025+" litres every hour");
            Console.WriteLine("This Wastes " + 86400 / dripTime * 0.00025+" litres every day");
            Console.WriteLine("This Wastes " + 604800 / dripTime * 0.00025+" litres every week");
            Console.ReadLine();
        }
    }
}

