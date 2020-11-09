using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap_levinhnga
{
    class bt3
    {
        public int m;
        public void kiemtrasoM()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("mời bạn nhập số m: ");
            int m = int.Parse(Console.ReadLine());
            if(m > 0)
            {
                Console.WriteLine("n= 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("n= 0");
            }
            if (m < 0)
            {
                Console.WriteLine("n= -1");
            }
            Console.ReadKey();
        }
    }
}
