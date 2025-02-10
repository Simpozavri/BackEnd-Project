using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_Project
{
    internal class ATM
    {

        static void Main()
        {
            int balance = 1000;
            while (true)
            {
                Console.WriteLine("1. Sheamowme balansi\n2. Tanxis shetana\n3. Tanxis ganagdeba\n4. Gasvla");
                Console.Write("airchiet varianti: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"tqvens angarishzea: {balance}");
                        break;
                    case "2":
                        Console.Write("Sheiyvanet shesatani tanxis raodenoba: ");
                        balance += int.Parse(Console.ReadLine());
                        break;
                    case "3":
                        Console.Write("Sheiyvanet gasanagdebeli tanxis raodenoba: ");
                        int amount = int.Parse(Console.ReadLine());
                        if (amount > balance) Console.WriteLine("arasakmarisi balansi.");
                        else balance -= amount;
                        break;
                    case "4":
                        return;
                }
            }
        }

    }
}
