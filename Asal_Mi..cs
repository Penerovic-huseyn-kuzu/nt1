using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_Mı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("girdiğiniz sayıya kadar olan asal sayıları yazar :");
            int sayi = Convert.ToInt16(Console.ReadLine());
            bool asalmi = true;

            for (int i = 2; i <= sayi; i++)
            {
                for (int j = 2;  j<i;j++)
          
            {
                if (i % j == 0)
                {
                    asalmi = false;
                    break;
                }
            }
            if (asalmi !== true)

                Console.Write(i + " ");
            asalmi = true;
        }



        }
    }
}
