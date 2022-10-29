using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb3
{
    class Program
    {
        static void converter(int _input)
        {
            int decision;
            Console.WriteLine("\nВ какую систему счисления переводить?\n1) Двоичную\n2) Восьмиричную\n3) Шестнадцатиричную\n");
            while (true)
            {
                decision = Convert.ToInt16(Console.ReadKey().Key);
                Console.Write("\b");
                switch (decision)
                {
                    case 49:
                        {
                            Console.WriteLine("{0} в двоичной системе счисления = {1}", _input, Convert.ToString(_input, 2));
                            return;
                        }
                    case 50:
                        {
                            Console.WriteLine("{0} в восьмеричной системе счисления = {1}", _input, Convert.ToString(_input, 8));
                            return;
                        }
                    case 51:
                        {
                            Console.WriteLine("{0} в шестнадцатиричной системе счисления = {1}", _input, Convert.ToString(_input, 16));
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Неверный выбор, попробуйте еще раз");
                            break;
                        }
   
                }
            }

        }



        static void Main(string[] args)
        {
            while (true)
            {
                int input;
                try
                {
                    Console.WriteLine("\nВведите число");
                }
                catch
                {
                    Console.WriteLine("\nНеверный ввод, попробуйте еще раз\n");
                }


                try
                {
                    converter(input = Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("\nНеверный ввод, попробуйте еще раз\n");
                }
            }
        }
    }
}
