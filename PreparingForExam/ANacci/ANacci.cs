using System;

class ANacci
{
    static void Main()
    {
        int shift = 64;

        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;

        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;

        int rowsNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((char)(first + shift));

        if (rowsNumber > 1)
        {
            int next = first + second;

            if (next > 26)
            {
                next = next % 26;
            }

            Console.WriteLine("{0}{1}", (char)(second + shift), (char)(next + shift));
            first = second;
            second = next;

            for (int i = 3; i <= rowsNumber; i++)
            {
                next = first + second;
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next;

                next = first + second;
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next;

                Console.Write((char)(first + shift));
                Console.Write(new string(' ', i - 2));
                Console.WriteLine((char)(second + shift));
            }
        }
    }
}