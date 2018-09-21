using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="";
            int x = 0;
            int checkx = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int l = 0;
            Console.WriteLine("Введите 9 чисел:");
            for (x = 1; x <= 9; x++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                checkx++;
                if (checkx == 1) { a = x; }
                else
                if (checkx == 2) { b = x; }
                else
                if (checkx == 3)
                {
                    c = x;

                    l = a;
                    a = c;
                    c = b;
                    b = l;

                    s = s + Convert.ToString(a) + ' ' + Convert.ToString(b) + ' ' + Convert.ToString(c) + ' ';
                    checkx = 0;
                }
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
