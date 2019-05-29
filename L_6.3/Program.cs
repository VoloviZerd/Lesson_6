using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Дана строка. Затем он вводит ключ из 6 чисел, например 314256. Зашифровать строку и вывести шифр.
//3. Пользователь вводит шифр (тот же, каким шифровали) и ему расшифровывется строка.

namespace L_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести ключ: ");
            int k = Int32.Parse(Console.ReadLine());
            int c = k;
            int count = 0;
            while (c > 1)
            {
                c = c / 10;
                count++;
            }
            c = k;
            int[] key = new int[count];

            for (int i=0;i<count;i++)
            {
                key[count - 1 - i] = c % 10;
                c = c / 10;
                
            }
            for (int i = 0;i<count;i++)
            {
                Console.Write("{0} ", key[i]);
            }
        }
    }
}
