using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//1. Пользователь вводит строку. Затем он вводит символ. Удалить этот символ из строки.


namespace L_6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            
            var S = s.ToCharArray();

            //foreach (char a in S)
            //{
            //    Console.Write("{0}", a);
            //}
            Console.WriteLine();
            int End = S.Length-1;
            int Idx = 0;
            int k = 0;
            Console.Write("Введите символ, который нужно удалить: ");
            char D = Char.Parse(Console.ReadLine());

            while(k != End)
            {
                Idx = s.IndexOf(D);
                k++;
            }

            s = s.Remove(Idx);

            Console.Write(s);

            char[] l = new char[S.Length - Idx];
            for (int i = Idx+1; i < S.Length; i++)
            {
                Console.Write("{0}", S[i]);
            }

            Console.WriteLine();


            
            
            

        }
    }
}
