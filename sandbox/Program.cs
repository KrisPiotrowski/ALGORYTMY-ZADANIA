using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int j = 1;
            string str = "";
            while (i <= x)
            {
                string rdln = Console.ReadLine().ToString();
                if(rdln != "")
                {
                    if (j != 9)
                    {
                        str += rdln + "?"; //oddzielenie wierszy
                        j++;
                    }
                    else
                        str += rdln;
                }
                else
                {
                    i++;
                    str += "|";
                    j = 1;
                }
                
                if (i == x && j == 9)
                    break;
            }

            Console.WriteLine(str);

            //string[] tab = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("komorka 0: \n" + tab[0]);
            //string[] firstTab = tab[0].Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
