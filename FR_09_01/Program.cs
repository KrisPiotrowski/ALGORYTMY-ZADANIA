using System;

namespace FR_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt= Array.ConvertAll(tab, int.Parse);

            if (tabInt[0] == 0 && tabInt[1] == 0)
                Console.Write(4);
            else if (tabInt[2] == Math.Sqrt((tabInt[0]* tabInt[0])+ (tabInt[1]* tabInt[1])))
                Console.Write(3);
            else
            {
                Console.Write(Sprawdz(tabInt[2], tabInt[1]) + Sprawdz(tabInt[2], tabInt[0]));
            }

        }

        public static int Sprawdz(int r, int wsp)
        {
            wsp = Math.Abs(wsp);
            return r == wsp ? 1:(r > wsp ? 2 : 0);

        }
    }
}
