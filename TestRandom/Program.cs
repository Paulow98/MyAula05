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
            int soma = 0;
            Console.Write("Amount of dices:");
            int nDados = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for(int i = 0; i< nDados; i++)
            {
                int tmp = random.Next(1, 7);
                soma += tmp;
                Console.WriteLine($"You rolled a {tmp}");
            }
            Console.WriteLine($"Total: {soma}");
        }
    }
}
