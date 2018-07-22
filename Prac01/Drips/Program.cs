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
            Int32 number;
            bool b = Int32.TryParse(strDrip, out number);
            if (b) 
            {
                Int32 dripTime = Convert.ToInt32(strDrip);
                Console.WriteLine("This Wastes " + (Convert.ToInt16(3600 / dripTime * 0.00025) / 0.25) + " cups of water every hour");
                Console.WriteLine("This Wastes " + (Convert.ToInt16(86400 / dripTime * 0.00025) / 0.25) + " cups of water every day");
                Console.WriteLine("This Wastes " + (Convert.ToInt16(604800 / dripTime * 0.00025) / 0.25) + " cups of water every week");
            }
            else
            {
                Console.WriteLine("That was not a number.");
            }
                Console.ReadLine();
        }
    }
}

