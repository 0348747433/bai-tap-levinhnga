using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap_levinhnga
{
    class sosanh
    {
        public void sosanh3so()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.Write("Mời bạn nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số c: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("giá trị lớn nhất trong 3 số là {0}", a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("giá trị lớn nhất trong 3 số là {0}", b);
            }
            else
            {
                Console.WriteLine("giá trị lớn nhất trong 3 số là {0}", c);
            }
        }
    }
}
