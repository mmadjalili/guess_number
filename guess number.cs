using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hadseadad
{ 
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        int numGuesses = 0;

        Console.WriteLine("عدد بین 1 تا 100 را حدس بزنید");

        while (guess != secretNumber)
        {
            Console.Write("حدس خود را وارد کنید ");
            guess = int.Parse(Console.ReadLine());
            numGuesses++;

            if (guess < secretNumber)
            {
                Console.WriteLine("خیلی کم. دوباره حدس بزنید");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("خیلی زیاد. دوباره حدس بزنید");
            }
        }

        Console.WriteLine("{0}  ***!!بردی***", numGuesses);
    }
}