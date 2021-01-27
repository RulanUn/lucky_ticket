using System;
using System.Linq;

//  Задание 2
namespace DZ_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки счастливого билета.");
            Console.Write("Введите 6-значеный номер трамвайного билета: ");


            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => Convert.ToInt32(s)).ToArray();
            if (ch.Length == 6)
            {
                int leftNumbers = 0;
                int rightNumbers = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumbers += ticketNumber[i];
                    }
                    else rightNumbers += ticketNumber[i];
                }
                if (leftNumbers == rightNumbers)
                {
                    Console.WriteLine("Билет счастливый!");
                }
                else Console.WriteLine("Счастливый билет будет в следующий раз!");
            }
            else Console.WriteLine("В номере билета должно быть 6 цифр");

            Console.Read();
        }
    }
}

