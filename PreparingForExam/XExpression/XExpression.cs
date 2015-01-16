using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class XExpression
{
    static void Main()
    {
        //4+6/5+(4*9–8)/7*2=

        int symbol = Console.Read();
        decimal sum = 0;
        int operation = '+';

        while (symbol != '=')
        {
            if (symbol == '(')
            {
                decimal innerSum = 0;
                int innerOperation = '+';
                symbol = Console.Read();

                while (symbol != ')')
                {
                    if (0 <= symbol - '0' && symbol - '0' <= 9)
                    {
                        switch (innerOperation)
                        {
                            case '+':
                                innerSum += symbol - '0';
                                break;
                            case '-':
                                innerSum -= symbol - '0';
                                break;
                            case '*':
                                innerSum *= symbol - '0';
                                break;
                            case '/':
                                innerSum /= symbol - '0';
                                break;
                        }
                    }
                    else if (symbol == '+' || symbol == '-' ||
                             symbol == '/' || symbol == '*')
                    {
                        innerOperation = symbol;
                    }
                    symbol = Console.Read();
                }

                switch (operation)
                {
                    case '+':
                        sum += innerSum;
                        break;
                    case '-':
                        sum -= innerSum;
                        break;
                    case '*':
                        sum *= innerSum;
                        break;
                    case '/':
                        sum /= innerSum;
                        break;
                }
            }
            else if (0 <= symbol - '0' && symbol - '0' <= 9)
            {
                switch (operation)
                {
                    case '+':
                        sum += symbol - '0';
                        break;
                    case '-':
                        sum -= symbol - '0';
                        break;
                    case '*':
                        sum *= symbol - '0';
                        break;
                    case '/':
                        sum /= symbol - '0';
                        break;
                }
            }
            else if (symbol == '+' || symbol == '-' ||
                     symbol == '*' || symbol == '/')
            {
                operation = symbol;
            }

            symbol = Console.Read();
        }
        Console.WriteLine("{0:F2}",sum);
    }
}