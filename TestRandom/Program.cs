using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount of dices:");
            int nDados = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for(int i = 0; i< nDados; i++)
            {
                Console.WriteLine($"You rolled a {random.Next(1, 7)}");
            }
        }
    }
}
