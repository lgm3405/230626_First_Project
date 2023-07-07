using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Project
{
    public class Test
    {
        public void TestGroup(ref int user_hp, ref int user_atk, ref int user_dfd)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("값들 : {0}, {1}, {2}", user_hp, user_atk, user_dfd);
                ConsoleKeyInfo something = Console.ReadKey();

                if (something.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
        }
    }
}
