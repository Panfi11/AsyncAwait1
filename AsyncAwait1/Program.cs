using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[100];
            PienaArray(n);
            Console.WriteLine("Immetti un numero :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(TrovaNumeriAsync(n1, n).Result);
            Console.ReadLine();
        }
        private static async Task<bool> TrovaNumeriAsync(int n, int[] array)
        {
            bool trovato = false;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (n == array[i])
                    {
                        trovato = true;
                    }
                }
            });

            return trovato;
        }
        private static void PienaArray(int[] numeri)
        {
            Random r = new Random();
            for (int n = 0; n < 100; n++)
            {
                numeri[n] = r.Next(0, 100);
            }
        }
    
    }
}
