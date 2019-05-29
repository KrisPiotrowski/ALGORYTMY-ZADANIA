using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_05_01
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {

            int Q = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Q; i++)
            {
                bool num = false;
                if (i == Q)
                    num = true;
                Solution(num);
            }
            Console.WriteLine(wynik.ToString());
        }

        static void Solution(bool j)
        {
            string[] tab = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string txt = tab[0].ToLower();
            int nr = txt == "pn" ? 1 : (txt == "wt" ? 2 : (txt == "sr" ? 3 : (txt == "cz" ? 4 : (txt == "pt" ? 5 : (txt == "so" ? 6 : (txt == "nd" ? 7 : 0))))));

            int nowyNr = (nr + Convert.ToInt32(tab[1]))%7;

            string result = nowyNr == 1 ? "Pn" : (nowyNr == 2 ? "Wt" : (nowyNr == 3 ? "Sr" : (nowyNr == 4 ? "Cz" : (nowyNr == 5 ? "Pt" : (nowyNr == 6 ? "So" : (nowyNr == 0 ? "Nd" : ""))))));


            if (!j)

                wynik.Append($"{result}\n");
            else
                wynik.Append($"{result}");
        }

    }
}
