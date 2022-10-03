using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_1214073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >10 || a<= 0)
            {
                Console.WriteLine("angka tidak sesuai");
            }
            else
            {
                for(int n= a;n >0; n--)
                    if(n== 1)
                {
                    Console.WriteLine("Anak Ayam Turunlah 1, mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine("Anak Ayam turunlah" + n + "Mati satu tinggalah" + (n - 1));
                    }
            }
        }
    }
}
