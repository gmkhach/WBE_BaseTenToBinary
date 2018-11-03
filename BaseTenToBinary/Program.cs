using System;
using System.Collections;
using System.Collections.Generic;

namespace BaseTenToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter an integer betwen 0 and 100\n\n>>> ");
                    int input = int.Parse(Console.ReadLine());
                    if (input < 0 || input > 100)
                    {
                        Console.Clear();
                        throw new Exception("Invalid Entry!");
                    }
                    Console.WriteLine("\nBinary equivalent: " + BaseTenToBinary(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another number...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int BaseTenToBinary(int baseTen)
        {
            if (baseTen == 0)
            {
                return 0;
            }

            string binary = string.Empty;

            // deviding the input number over two and collecting into a string
            while(baseTen != 0)
            {
                binary = Convert.ToString(baseTen % 2) + binary;
                baseTen /= 2;
            }

            return int.Parse(binary);
        }
    }
}
