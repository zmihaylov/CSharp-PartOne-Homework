using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinaryDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int row = 0; row < 4; row++)
        {
            for (int i = 15; i >= 0; i--)
            {
                int bit = (number >> i) & 1;

                if (bit == 1)
                {
                    if (row == 0 || row == 2)
                    {
                        Console.Write(".#.");
                    }
                    else if (row == 1)
                    {
                        Console.Write("##.");
                    }
                    else if (row == 3)
                    {
                        Console.Write("###");
                    }
                }
                else
                {
                    if (row == 0 || row == 3)
                    {
                        Console.Write("###");
                    }
                    else if (row == 1 || row == 2)
                    {
                        Console.Write("#.#");
                    }
                }

                if (i > 0)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}



