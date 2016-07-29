using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número:");
            int.Parse(Console.ReadLine());
        }

        static int raiz(int n)
        {
            
            int i = 1;
            int dif = n - i;
            int termos = 1;
            while (dif != 0)
            {
                n -= i;
                i += 2;
                dif = n - i;
                termos++;
            }
            return termos;

        }

    }
}
