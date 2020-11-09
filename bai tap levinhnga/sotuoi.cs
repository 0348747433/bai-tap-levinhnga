using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap_levinhnga
{
    class sotuoi
    {
        public int tuoi;
        public void nhapsotuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.Write("Mời bạn nhập số tuổi:");
            int tuoi = int.Parse(Console.ReadLine());


            if (tuoi > 17)
            {
                Console.WriteLine("bạn đã đủ tuổi bầu cử");
            }    
            else
            {
                Console.WriteLine("bạn chưa đủ tuổi bầu cử");
            }    
        }
    }
}
