using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str ,close;
            int i, soz;
            Console.WriteLine("Metni daxil edin:\n");
            str = Console.ReadLine();
            i = 0;
            soz = 1;
            while (i <= str.Length - 1)
            {
                if (str[i] ==' ' || str[i] == '\n')
                {
                    soz++;
                }
                i++;
        
            }
            Console.WriteLine("Metndeki sozlerin sayi:{0}\n", soz);
            

        }
    }
}
