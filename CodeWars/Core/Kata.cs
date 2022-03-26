using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Core
{
    public  static  class Kata
    {
        /// <summary>
        /// return the count of numbers Odd below a given Number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ulong OddCount(ulong n) =>  n / 2;


        /// <summary>
        /// return the hexadecimal value
        /// </summary>
        public static string Rgb(int r, int g, int b)
        {
            r = r < 0 ? 0 : r > 255 ? 255 : r;
            g = g < 0 ? 0 : g > 255 ? 255 : g;
            b = b < 0 ? 0 : b > 255 ? 255 : b;
            return $"{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}";
        }

    }
}
