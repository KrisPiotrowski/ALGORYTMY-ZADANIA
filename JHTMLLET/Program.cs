using System;
using System.Text;

namespace JHTMLLET
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
                Solution();
        }

        static void Solution()
        {
            StringBuilder wczytanyTekst = new StringBuilder(100000);

            while (1==1)
            {
                string tekst = Console.ReadLine();
                if(tekst.ToLower() == "</html>")
                {
                    wczytanyTekst.Append($"{tekst}\n");
                    break;
                }
                else 
                wczytanyTekst.Append($"{tekst}\n"); 
            }

            string nowyTekst = "";
            int znacznikOpenTag = 0;
            
            for (int i = 0; i < wczytanyTekst.Length; i++)
            {
                if (wczytanyTekst[i].ToString() == "<")
                {
                    znacznikOpenTag = 1;
                }
                if (wczytanyTekst[i].ToString() == ">")
                {
                    znacznikOpenTag = 0;
                }
                string litera = znacznikOpenTag == 1 ? wczytanyTekst[i].ToString().ToUpper() : wczytanyTekst[i].ToString();

                nowyTekst += litera;
            }

            Console.Write(nowyTekst);
        }
    }
}