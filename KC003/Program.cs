using System;
using System.Text;
using System.Collections.Generic;

namespace KC003
{
    class Program
    {
        static StringBuilder wynik = new StringBuilder(100000);

        static void Main(string[] args)
        {
            try
            {
                Solution();
                Console.WriteLine(wynik.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(wynik.ToString());
                return;
            }
        }

        static void Solution()
        {
            string result = "";
            string text = "";

            while (1 == 1)
            {
                string t = Console.ReadLine().ToString();

                if (t != string.Empty && t!= null)
                {
                    text += t + "?";
                }
                else
                {
                    text = text.Substring(0, text.Length - 1);
                    break;
                }
            }
            
            /*
            string line = string.Empty;

            Input:
            line = Console.ReadLine();

            if (line != string.Empty)
            {
                text += line + "?";
                goto Input;

            }*/
         
            

            string[] tab = text.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < tab.Length; i++)
            {
                string[] tab2 = tab[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
 
                double[] tabDbl = Array.ConvertAll(tab2, double.Parse);

                if (tabDbl[0] > 0 && tabDbl[1] > 0 && tabDbl[2] > 0)
                {
                    if (tabDbl[0] + tabDbl[1] > tabDbl[2] && tabDbl[2] + tabDbl[1] > tabDbl[0] && tabDbl[0] + tabDbl[2] > tabDbl[1])
                        result = "1";
                }
                else
                    result = "0";

                wynik.Append($"{result}\n");
            }
            
            
            
        }
    }
}
