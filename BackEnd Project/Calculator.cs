using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Project
{
    public class Calculator
    {

        static void Main()
        {
            Console.WriteLine("Martivi kalkulatori");
            double num1, num2, result = 0;
            char operation;

            // Input validation
            Console.Write("Sheiyvanet ricxvi: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Ricxvi arasworia. Sheiyvanet swori ricxvi: ");
            }

            Console.Write("Sheiyvanet operacia (+, -, *, /): ");
            while (!char.TryParse(Console.ReadLine(), out operation) ||
                   (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
            {
                Console.Write("Araswori operacia. Sheiyvanet chamotvliltagan erterti (+, -, *, /): ");
            }

            Console.Write("Sheiyvanet meore ricxvi: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Ricxvi arasworia. Sheiyvanet swori ricxvi: ");
            }

            // Perform operation
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Nulze gayofa ar sheidzleba.");
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Shedegi: {num1} {operation} {num2} = {result}");
        }

    }
}
