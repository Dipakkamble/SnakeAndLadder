using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPosition = 0;
            Console.WriteLine("welcome to snake and ladder program");
            Random random= new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine("The player roll a die:" +dieValue);
            //Console.WriteLine("single player start position : " +startPosition);
            Console.ReadLine();
        }
    }
}
