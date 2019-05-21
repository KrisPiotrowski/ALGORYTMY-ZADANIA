using System;

namespace FR_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        static void Solution()
        {

            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tabInt = Array.ConvertAll(tab, int.Parse);

            int cntX = 1;

            if (tabInt[2] != tabInt[0])
                cntX += 1;

            if (tabInt[4] != tabInt[2] && tabInt[4] != tabInt[0])
                cntX += 1;

            if (tabInt[6] != tabInt[4] && tabInt[6] != tabInt[2] && tabInt[6] != tabInt[0])
                cntX += 1;

            int cntY = 1;

            if (tabInt[3] != tabInt[1])
                cntY += 1;

            if (tabInt[5] != tabInt[3] && tabInt[5] != tabInt[1])
                cntY += 1;

            if (tabInt[7] != tabInt[5] && tabInt[7] != tabInt[3] && tabInt[7] != tabInt[1])
                cntY += 1;

            if (cntX == 2 && cntY == 2)
                Console.WriteLine("Tak");
            else Console.WriteLine("Nie");
        }
    }
}
