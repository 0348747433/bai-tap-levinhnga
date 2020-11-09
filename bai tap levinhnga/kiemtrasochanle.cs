using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace bai_tap_levinhnga
{
    class kiemtrasochanle
    {
        public int a;
        public void nhapso()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.Write("Mời bạn nhập số a : ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Số chẵn là: {0} ", +a);
            }    
            if (a % 2 != 0)
            {
                Console.WriteLine("Số lẻ là: {0}", +a);
            }    
            Console.ReadKey();
        }


    }
}

