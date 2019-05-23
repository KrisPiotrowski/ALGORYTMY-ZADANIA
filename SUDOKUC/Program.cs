using System;

namespace SUDOKUC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                string str = "";
                string result = "";

                while (i <= 9 * x)
                {
                    string rdln = Console.ReadLine().ToString();

                    if (rdln != "")
                    {
                        if (i % 9 == 0 && i == 9 * x)
                            str += rdln;
                        else if (i % 9 == 0 && i < 9 * x)
                            str += rdln + "|";
                        else
                            str += rdln + "?";

                        i++;
                    }
                }

                string[] tab = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                for(int f = 0; f < tab.Length; f++)
                {
                    if(f< tab.Length - 1)
                    {
                        result += CheckTable(tab[f]) + "\n";
                    }
                    else
                    {
                        result += CheckTable(tab[f]);
                    }
                }
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                return;
            }
        }

        public static string CheckTable(string arg)
        {
            int[,] tab = new int[9, 9];
            string[] tabRows = arg.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < tabRows.Length; i++)
            {
                string[] tabElem = tabRows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] tabInt = Array.ConvertAll(tabElem, int.Parse);

                for(int j = 0; j < tabInt.Length; j++)
                {
                    tab[i, j] = tabInt[j];
                }
            }

            foreach (int x in tab)
            {
                if (x < 1 || x > 9)
                    return "NIE";
            }

            //sprawdz rzędy
            for(int i = 0; i < 9; i++)
            {
                int[] chkTab = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    chkTab[tab[i, j]-1] = 1;
                }
                foreach (int x in chkTab)
                    if (x == 0)
                        return "NIE";
            }

            //sprawdz kolumny
            for (int i = 0; i < 9; i++)
            {
                int[] chkTab = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    chkTab[tab[j, i] - 1] = 1;
                }
                foreach (int x in chkTab)
                    if (x == 0)
                        return "NIE";
            }

            //sprawdź kwadraty
            int chkSum = CheckSquares(tab, 0, 0) +
                           CheckSquares(tab, 3, 0) +
                           CheckSquares(tab, 6, 0) +
                           CheckSquares(tab, 0, 3) +
                           CheckSquares(tab, 3, 3) +
                           CheckSquares(tab, 6, 3) +
                           CheckSquares(tab, 0, 6) +
                           CheckSquares(tab, 3, 6) +
                           CheckSquares(tab, 6, 6);

            if (chkSum > 0)
                return "NIE";

            return "TAK";
        }

        static int CheckSquares(int[,] tab, int i, int j)
        {
            int i3 = i + 3;
            int j3 = j + 3;
            int[] chkTab = new int[9];
            for (int x = i; x < i3; x++)
            {
                for (int y = j; y < j3; y++)
                {
                    chkTab[tab[y, x] - 1] = 1;
                }

            }
            foreach (int f in chkTab)
                if (f == 0)
                    return 1;

            return 0;
        }
    }
}
