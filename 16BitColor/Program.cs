using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16BitColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Red:");
            var redstr = Console.ReadLine();
            Console.Write("Green:");
            var greenstr = Console.ReadLine();
            Console.Write("Blue:");
            var bluestr = Console.ReadLine();

            var red = short.Parse(redstr);
            var green = short.Parse(greenstr);
            var blue = short.Parse(bluestr);

            short val = GetShort(red, green, blue);

            Console.WriteLine(val.ToString("X"));
            Console.ReadLine();
        }
        public static short GetShort(short red, short green, short blue)
        {
            red >>= 3;
            green >>= 2;
            blue >>= 3;
            return (short)((red << 11) | (green << 5) | blue);
        }
    }
}
