using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            //if(
            //    a%2==0 &&
            //    b%2==0

            //   )
            //{
            //    Console.WriteLine(true);
            //}

            //else if (
            //    a % 2 == 1 &&
            //    b % 2 == 1

            //   )
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //if (str1.Contains(str2))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);   
            //}

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //double num3 =(double) num1 / num2;
            //int num4 = num1 % num2;
            //float num5 = (num4 / num2); ;
            //float num6 = num3 + num5;
            //double s = 121234566788888888888.34565355555555555555533335626789f;
            //var a = 5;
            //var b = 7;
            //int num1 = int.Parse(Console.ReadLine());
            //var c = 9;
            //int num2 = int.Parse(Console.ReadLine());
            //var result = a + b + c; 
            DateTime date1 = DateTime.Now;
            //var date2 = DateTime.Parse('10.07.2012 20:03:50');
            //TimeSpan timeRange = date1 - date2;
            Console.WriteLine(date1.ToLongDateString());
            Console.WriteLine(date1.Add(TimeSpan.Parse("5.23:35:56")));
            Console.ReadLine();






        } 
    }
}
