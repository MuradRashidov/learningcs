using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5.extensions
{
    public static class MyExtensions
    {
        public static void Greeting(this User1 user1)
        {
            Console.WriteLine($"Hello {user1.Name}");

        }
    }
}
