using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your name more than 6 letters long? (Yes or No(CaSe SenSiTIve))");
            var answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                Console.WriteLine("Well woop-dee-doo.");
            }
            else if (answer.Equals("No"))
            {
                Console.WriteLine("Wow, you are execptionally cool by your standards alone.");
            }
            else
            {
                Console.WriteLine("Was Yes or No not clear enough for you?");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Please enter your name below.");
            var name = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ", is this correct?(Yes or No(CaSe SenSiTIve))");
            var confirm = Console.ReadLine();
            if (confirm.Equals("Yes"))
            {
                Console.WriteLine("Alright, you can go home now. Thank you for cooperating in your kidnapping experience, that you signed up, and paid for.");
            }
            else if (confirm.Equals("No"))
            {
                Console.WriteLine("The sooner you cooperate, the sooner you can go home to your previous life style.");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
