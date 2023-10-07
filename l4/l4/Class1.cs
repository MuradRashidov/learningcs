using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    public class Class1
    {
        public static void 
            asd()
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //int sum = 0;
            //for(int i = 0; i < 40; i++) {
            //    if (i%2==1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //multplication(a, b);
            int num = 9;
            int sum = 0;
            
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine(num);

                    sum += num;
                    num = num * 10 + 9;

                }
                Console.WriteLine();

            string a = "ads";
            
        }
        internal static void multplication(int a, int b) {
            for (int i = 0; i <= a; i++) {
                Console.WriteLine($"{b}*{i}={b*i}");

            }
              
        }
    }
}
