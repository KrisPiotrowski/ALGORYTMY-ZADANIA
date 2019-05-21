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
            int[][] tab = new int[4][];

            string[] tabString = "4,5".Split(',');
            tab[0] = Array.ConvertAll(tabString, int.Parse);
            Console.WriteLine("element zero: "+tab[0][0].ToString()+","+ tab[0][1].ToString());

            tabString = "2,3".Split(',');
            tab[1] = Array.ConvertAll(tabString, int.Parse);
            Console.WriteLine("element 1: " + tab[1][0].ToString() + "," + tab[1][1].ToString());

            tabString = "0,2".Split(',');
            tab[2] = Array.ConvertAll(tabString, int.Parse);
            Console.WriteLine("element 2: " + tab[2][0].ToString() + "," + tab[2][1].ToString());

            tabString = "8,9".Split(',');
            tab[3] = Array.ConvertAll(tabString, int.Parse);
            Console.WriteLine("element 3: " + tab[3][0].ToString() + "," + tab[3][1].ToString());

            Array.Sort(tab);
            Console.WriteLine("Po sortowaniu:");
            Console.WriteLine("element zero: " + tab[0][0].ToString() + "," + tab[0][1].ToString());
            Console.WriteLine("element 1: " + tab[1][0].ToString() + "," + tab[1][1].ToString());
            Console.WriteLine("element 2: " + tab[2][0].ToString() + "," + tab[2][1].ToString());
            Console.WriteLine("element 3: " + tab[3][0].ToString() + "," + tab[3][1].ToString());
        }
    }
}
