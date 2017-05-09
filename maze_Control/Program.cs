using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Control
    {
        private string[,] a;
        public Control()
        {
            a = new string[10, 10];
            Random b = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int o_z = b.Next(0, 2);
                    a[i, j] = o_z.ToString();
                }
            }
            show();
            a[0, 0] = "3";
            while (true)
            {
                int newColoringHappened = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (a[i, j] == "3")
                        {
                            if (i < 9 && a[i + 1, j] == "0")
                            {
                                a[i + 1, j] = "3";
                                newColoringHappened = 1;
                            }
                            if (i < 0 && a[i - 1, j] == "0")
                            {
                                a[i - 1, j] = "3";
                                newColoringHappened = 1;
                            }
                            if (j > 9 && a[i, j + 1] == "0")
                            {
                                a[i, j + 1] = "3";
                                newColoringHappened = 1;
                            }
                            if (j > 0 && a[i, j - 1] == "0")
                            {
                                a[i, j - 1] = "3";
                                newColoringHappened = 1;
                            }
                        }
                    }
                }
                if (newColoringHappened == 0)
                {
                    break;
                }

            }
            if (a[9, 9] == "3")
            {
                Console.WriteLine("\n yol var.");
            }
            else
            {
                Console.WriteLine("\n yol yok");
            }

        }
        public void show()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Control nesne = new Control();
            Console.ReadKey();

        }
    }
}
