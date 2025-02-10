using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Project
{
    internal class GTN
    {

        static void Main()
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int guess;
            int attempts = 0;

            Console.WriteLine("ketili iyos sheni mobrdzaneba ricxvebis gamocnobanashi");
            Console.WriteLine("Sheecade gamoicno ricxvi 1-dan 100-mde");

            do
            {
                Console.Write("Chawere ricxvi: ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Araswori ricxvia. Sheiyvanet ricxvi 1-dan 100-mde: ");
                }

                attempts++;

                if (guess > targetNumber)
                {
                    Console.WriteLine("Dzalian magali ricxvia. Kidev scade");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Dzalian dabali ricxvia. Kidev scade");
                }
                else
                {
                    Console.WriteLine($"Gilocav! shen {attempts} cdashi gamoicani chemi chafiqrebuli ricxvi.");
                }
            } while (guess != targetNumber);
        }

    }
}
