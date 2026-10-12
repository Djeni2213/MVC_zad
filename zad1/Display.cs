using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Display
    {
        public int Distance { get; set; }
        public string DayTime { get; set; }
        public double Price { get; set; }

        public void InputInfo()
        {
            Console.Write("Enter how many kilometers you will travel: ");
            Distance = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Are you travelling day or night? (write \"day\" or \"night\"): ");
            DayTime = Console.ReadLine().ToLower();
        }

        public void OutputPrice()
        {
            Console.WriteLine($"The lowest price for your transport is {Price:f2}");
        }
    }
}
