using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONGULER_ORNEK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KULLANICININ GİRDİĞİ SAYIYA KADAR OLAN SAYILARIN FAKTÖRİYELLERİNİ BULAN PROGRAM 
            Console.Write("SAYI GİRİNİZ : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f;
            for ( int i=1; i<=n;i++)
            {
                f = 1;
                int j = i;
                Console.Write(j+" ");
                for (; j > 0; j--)
                {
                    f = f * j;
                }
                Console.WriteLine( " SAYISININ FAKTÖRİYELİ = {0} ", f);
            } Console.ReadLine();
        }
    }
}
