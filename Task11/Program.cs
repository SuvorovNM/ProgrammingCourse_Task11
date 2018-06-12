using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static string Code(string input)//Создание зашифрованного сообщения
        {
            string result = "";
            result += input[0];//Первый элемент не изменяется
            for (int i = 1; i < input.Length; i++)
            {
                //Если текущий элемент (input[i]) равен предыдущему (input[i - 1]) в изначальной строке
                //То к зашифрованному сообщению добавляется "1", иначе "0"
                if (input[i] == input[i - 1])
                    result += "1";
                else result += "0";
            }
            return result;
        }
        static string Decode(string code)//Создание расшифрованного сообщения
        {
            string result = "";
            //Первый элемент не изменяется
            result += code[0];
            for (int i = 1; i < code.Length; i++)
            {
                //Если в коде "1", значит элемент не менялся, следовательно дописываем последний известный элемент
                if (code[i] == '1')
                    result += result[i - 1];
                else
                {
                    //Если в коде "0", значит элемент на этой позиции изменился и он не равен последнему известному элементу
                    //Соответственно, к итоговой строке добавляем противоположный temp символ и меняем на него переменную temp
                    if (result[i-1] == '0')
                    {
                        result += "1";                       
                    }
                    else
                    {
                        result += "0";                        
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string tocheck;
            string str;
            //Проверка на то, что введенная строка состоит только из "0" и "1"
            do
            {
                Console.WriteLine("Введите сообщение для его шифрования и расшифровки: ");
                str = Console.ReadLine();
                tocheck = str.Replace("1", "");
                tocheck = tocheck.Replace("0", "");
                if (tocheck != "") Console.WriteLine("Введена некорректная строка!");
            } while (tocheck != "" || str == "");
            Console.WriteLine("Закодированное сообщение: ");
            string temp = Code(str);
            Console.WriteLine(temp);
            Console.WriteLine("Расшифрованное сообщение: ");
            Console.WriteLine(Decode(temp));
            Console.Read();
        }
    }
}
