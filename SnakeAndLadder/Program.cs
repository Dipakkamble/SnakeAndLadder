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
            const int noPlay= 1, ladder = 2, snake = 3;
            Console.WriteLine("welcome to snake and ladder program");

            while (startPosition < 100)
            {   
                Random random = new Random();
                int dieValue = random.Next(1, 7);
                Console.WriteLine("The player roll a die:" + dieValue);
            
                int option = random.Next(1, 4);
                Console.WriteLine("option:" + option);

                switch (option)
                {
                    case noPlay:
                        Console.WriteLine("The player stays in the same position:" + startPosition);
                        break;
                    case ladder:                       
                        startPosition = startPosition + dieValue;
                        Console.WriteLine("player got ladder and move ahead :" + startPosition);
                        break;
                    case snake:
                        startPosition = startPosition - dieValue;
                        Console.WriteLine("player got snake and move behind :" + startPosition);
                        break;                      
                }
                if (startPosition < 0 )
                {
                    startPosition = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
