using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static string Code(string input)
        {
            string result = "";
            result += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                    result += "1";
                else result += "0";
            }
            return result;
        }
        static string Decode(string code)
        {
            string result = "";
            result += code[0];
            char temp = code[0];
            for (int i = 1; i < code.Length; i++)
            {
                if (code[i] == '1')
                    result += temp;
                else
                {
                    if (temp == '0')
                    {
                        result += "1";
                        temp = '1';
                    }
                    else
                    {
                        result += "0";
                        temp = '0';
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string t = "11111111111000000101010101010101010101001";
            string temp = Code(t);
            Console.WriteLine(Decode(temp));
            Console.Read();
        }
    }
}
