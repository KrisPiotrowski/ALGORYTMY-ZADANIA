using System;

namespace TRN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wsp = (Console.ReadLine()).Split(' ');
            int rzad = Convert.ToInt32(wsp[0]);
            int kol = Convert.ToInt32(wsp[1]);

            string[,] tab = new string[rzad, kol];

            int i = 0;
            while (i < rzad)
            {
                string[] tb = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;
                for(int j = 0; j < kol; j++)
                {
                    tab[i, j] = tb[j];
                }
                i++;
            }
            
            Solution(tab, rzad, kol);

        }

        public static void Solution(string[,] tab, int rzad, int kol)
        {
            for(int i = 0; i < kol; i++)
            {
                for (int j = 0; j < rzad; j++)
                {
                    Console.Write(tab[j,i]+" ");
                }
                Console.WriteLine(); 
            }
        }
    }

    
}
