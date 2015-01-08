using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(n, 2).PadLeft(11,'0');

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                Console.WriteLine("A" + i);
            }
        }
    }
}