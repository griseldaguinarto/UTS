using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollabUTS
{
    public class HitungKelipatan
    {
        static void Main(string[] args)
        {
            int x, n;

            Console.Write("Masukan X : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan N : ");
            n = Convert.ToInt32(Console.ReadLine());

            hitungKelipatan(x, n);
        }

        public static void hitungKelipatan(int x, int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                if (x == 0)
                {
                    total = 0;
                }
                else
                {
                    while (i % x == 0)
                    {
                        total += i;
                        i++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total adalah " + total);
        }
    }
}
