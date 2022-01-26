using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = 20061;
            int N = 22332501;
            double sh = 3455.67,sz=13780.30;
            double A = sh * sz * 10000;
            int num=Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int n = 0; n < 2022; n++)
            {
               
              double score = A % (B + n) % B + (N + 1);
                //Console.WriteLine(score);
                if(score==num)
                {
                    flag=1;
                }
                
            }
            for (int n = 2022; n < 4044; n++)
            {

                double score = A % (B + n) % B + (N + 1);
                if (score == num)
                {
                    flag = 2;
                }
            }
                if (flag==1)
               {
                Console.WriteLine("中奖");
               }

                if(flag==2)
               {
                    Console.WriteLine("替补中奖");
               }

                else
              {
                Console.WriteLine("未中奖");
              }
            Console.ReadKey();
        }
    }
}
