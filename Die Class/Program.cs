using System.Diagnostics.CodeAnalysis;
using System.Runtime;

namespace Die_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            int sum;

            die1 = new Die();
            die2 = new Die(ConsoleColor.DarkRed);

            Console.WriteLine("Die 1 is a " + die1);
            die1.DrawRoll();

            Console.WriteLine("Die 2 is a " + die2);
            die2.DrawRoll();

            sum = 7;
            
  

            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("You rolled Doubles.");

            }
            if (die1.Roll + die2.Roll == sum)
            {
                Console.WriteLine("You rolled a Sum of 7.");
            }
            if (die1.Roll == 1 && die2.Roll == 1)
            {
                Console.WriteLine("You rolled Snake Eyes.");
            }
            if ((die1.Roll + die2.Roll) % 2 == 0)
            {
                Console.WriteLine("You rolled a Even sum.");
            }

        }
    }
}
