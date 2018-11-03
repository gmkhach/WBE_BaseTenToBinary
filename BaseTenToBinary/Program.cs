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
                    Console.Write("\nEnter an integer betwen 1 and 100\n\n>>> ");
                    int input = int.Parse(Console.ReadLine());
                    if (input < 1 || input > 100)
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
            string binary = "1";
            Stack<string> myStack = new Stack<string>();

            while(baseTen != 1)
            {
                myStack.Push(Convert.ToString(baseTen % 2));
                baseTen = baseTen / 2;
            }
            while (myStack.Count != 0)
            {
                binary += myStack.Pop();
            }
                return int.Parse(binary);
        }
    }
}
