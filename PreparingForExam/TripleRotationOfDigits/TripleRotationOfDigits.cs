using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        //string k = Console.ReadLine();
        //int numK = int.Parse(k);

        //k = numK.ToString();
        //string temp = "";
        //if (k.Length == 1)
        //{
        //    temp = k;
        //}

        //if (k.Length == 2)
        //{
        //    temp = k[1] + "" + k[0];
        //}

        //if (k.Length >= 3)
        //{
        //    for (int i = k.Length - 3; i < k.Length; i++)
        //    {
        //        temp += k[i];
        //    }

        //    for (int i = 0; i < k.Length - 3; i++)
        //    {
        //        temp = temp + "" + k[i];
        //    }
        //}

        //int final = int.Parse(temp);
        //Console.WriteLine(final);

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            if (number > 9)
            {
                int lastDigit = number % 10;
                number /= 10;

                string result = lastDigit.ToString() + number.ToString();

                number = int.Parse(result);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(number);
    }
}