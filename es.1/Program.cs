using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void riempi(int[] a, int num, int max)
            {
                Random r = new Random();
                for (int i = 0; i < num; i++)
                {
                    a[i] = (r.Next(100));
                }
            }
            void scambio(int x, int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }
    }
}
