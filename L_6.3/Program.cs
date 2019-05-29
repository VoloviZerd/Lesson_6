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
# region Ввод и анализ ключа
            Console.Write("Ввести ключ: ");
            int k = Int32.Parse(Console.ReadLine());
            int c = k;
            int count = 0;
            while (c >= 1)
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
            #endregion

#region Анализ строки и деление на группы, кратные размеру ключа
            string word = "Не следует, однако, забывать о том, что дальнейшее развитие различных форм деятельности играет важную роль в формировании ключевых компонентов планируемого обновления.";
            char[] charWord = word.ToCharArray();

            Console.WriteLine();
            var keyGroup = Math.Ceiling((decimal)charWord.Length / count); //количество групп символов, кратный размеру ключа
            
            char[] wordGroup = new char[(int)keyGroup]; //Массив групп символов строки, кратный размеру ключа
            for (int i = 0; i < (int)keyGroup; i++)
            {
                int j = 0;
                while (j % count != 0)
                {
                    wordGroup[i] = 
                    j++;
                }
            }
            #endregion
        }
    }
}
