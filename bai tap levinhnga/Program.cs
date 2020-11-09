using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace bai_tap_levinhnga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số 1 nếu muốn xem bạn có đủ tuổi bầu cử chưa.");
            Console.WriteLine("nhập số 2 để kiểm tra số chẵn hay lẻ.");
            Console.WriteLine("nhập số 3 để nhập số tương ứng vs giá trị -1, 0, 1.");
            Console.WriteLine("nhập số 4 để so sánh 3 số bất kì.");
            Console.WriteLine("nhập số 5 để bấm số ra chữ :) ");
            Console.Write("Mời bạn nhập số : ");
            int D = int.Parse(Console.ReadLine());
            if (D == 1)
            {
                sotuoi st = new sotuoi();
                st.nhapsotuoi();
                
            }
            if(D == 2)
            {
                kiemtrasochanle ktscl = new kiemtrasochanle();
                ktscl.nhapso();
            }
            if(D == 3)
            {
                bt3 baitap3 = new bt3();
                baitap3.kiemtrasoM();
            } 
            if (D == 4)
            {
                sosanh ss = new sosanh();
                ss.sosanh3so();
            }
            Console.ReadKey();
        }
    }
}
