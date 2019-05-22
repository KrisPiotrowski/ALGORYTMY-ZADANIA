using System;

namespace FR_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] tabInt= Array.ConvertAll(tab, long.Parse);

            if (tabInt[2] == Math.Sqrt((tabInt[0] * tabInt[0]) + (tabInt[1] * tabInt[1])))
                Console.Write((Sprawdz(tabInt[2], tabInt[1]) + Sprawdz(tabInt[2], tabInt[0]) - 1).ToString());
            else
            {
                Console.Write((Sprawdz(tabInt[2], tabInt[1]) + Sprawdz(tabInt[2], tabInt[0])).ToString());
            }
        }

        public static int Sprawdz(long r, long wsp)
        {
            wsp = Math.Abs(wsp);
            return r == wsp ? 1:(r > wsp ? 2 : 0);

        }
    }
}
