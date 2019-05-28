using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] textFile;

            textFile = File.ReadAllLines(@"C:\Users\User\OneDrive\Работа\ЮТП\AVEVA Catalogue\Макросы для элементов каталога\TEE\TEE_R.txt");

            string[] command;
            for (int i = 0; i < textFile.Length; i++)
            {
                command = textFile[i].Split(' ');
                if(command[0] == "INPUT")
                {

                }

            }*/

            //Создать файл в нем написать инструкции для калькулятора.
            //mem 5    Запомнить число 5
            //mem 6    Запомнить в другую ячейку памяти число 6
            //+         Сложить числа в ячейках памяти и вывести результат на экран.
            //mem 14
            //mem 7
            // /
            //inv1     Инвертировать первое число
            //inv2     Инвертировать второе число
            //clear 1   Убирает число из ячейки 1
            //swap      Поменять числа местами


            float mem_1=0;
            float mem_2=0;
            float res = 0;
            bool flag = false;
            float tmp = 0;
            string[] Calc;
            Calc = File.ReadAllLines(@"C:\Users\User\OneDrive\C#(mi)\C#_practics\Lessons\Lesson_6\L_6.1\Calc.txt");
            //for(int i=0;i<Calc.Length;i++)
            //{
            //    if(Calc[i] == "")
            //    {
            //        Calc[i] = "#";
            //    }
            //}
            string[] Calc_Com;
            for (int i = 0; i < Calc.Length; i++)
            {
                Calc_Com = Calc[i].Split(' ');
                if(Calc_Com[0] == "")
                {
                    continue;
                }
                else if (Calc_Com[0] == "mem" && Calc_Com[1] == "res" && flag == false)
                {
                    mem_1 = res;
                    flag = true;
                }
                else if (Calc_Com[0] == "mem" && flag == false)
                {
                    mem_1 = float.Parse(Calc_Com[1]);
                    flag = true;
                }

                else if (Calc_Com[0] == "mem" && flag == true)
                {
                    mem_2 = float.Parse(Calc_Com[1]);
                    flag = false;
                }
                else if (Calc_Com[0] == "+")
                {
                    res = mem_1 + mem_2;
                    Console.WriteLine(mem_1 + mem_2);

                }


                else if (Calc_Com[0] == "/")
                {
                    Console.WriteLine(mem_1 / mem_2);
                }
                else if (Calc_Com[0] == "swap")
                {
                    tmp = mem_1;
                    mem_1 = mem_2;
                    mem_2 = tmp;
                }
                else if(Calc_Com[0] == "inv"+"1")
                {
                    mem_1 = -mem_1;
                }

                else if (Calc_Com[0] == "inv" + "2")
                {
                    mem_2 = -mem_2;
                }

                //string a = "slovo$";
               // a[a.Length - 1]




            }
        }

    }
}
