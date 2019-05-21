using System;

namespace FR_09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt= Array.ConvertAll(tab, int.Parse);

            //Console.WriteLine("sprawdzanie minus i plus - sprawdzenie");
            //Console.WriteLine("sprawdz minus(4, -1 ): " + SprawdzMinus(4, -1));
            //Console.WriteLine("sprawdz minus(4, -5 ): " + SprawdzMinus(4, -5));
            //Console.WriteLine("sprawdz minus(4, -4): " + SprawdzMinus(4, -4));
            //Console.WriteLine("sprawdz plus(4, 1 ): " + SprawdzPlus(4, 1));
            //Console.WriteLine("sprawdz plus(4, 5 ): " + SprawdzPlus(4, 5));
            //Console.WriteLine("sprawdz plus(4, 4): " + SprawdzPlus(4, 4));

            if (tabInt[0] == 0 && tabInt[1] == 0)
                Console.Write(4);
            else if ((double)tabInt[2] == Math.Sqrt(((double)tabInt[0]* (double)tabInt[0])+ (double)(tabInt[1]* (double)tabInt[1])))
                Console.Write(3);
            else
            {
                int x = Sprawdz(tabInt[2], tabInt[1]) + Sprawdz(tabInt[2], tabInt[0]);
                Console.Write(x);
            }

        }

        public static int Sprawdz(int r, int wsp)
        {
            wsp = Math.Abs(wsp);
            return r == wsp ? 1:(r > wsp ? 2 : 0);

        }
    }
}
