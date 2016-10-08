using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsAndTails
{
    class Solution
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] inputArray = input.Replace(" ", "").Split(',');
            int headsCount = 0;
            int tailsCount = 0;
            int currentCounter = 1;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1] && inputArray[i] == "H")
                {
                    currentCounter++;

                    if (currentCounter > headsCount)
                    {
                        headsCount = currentCounter;
                    }
                
                }

                else if (inputArray[i] == inputArray[i - 1] && inputArray[i] == "T")
                {
                    currentCounter++;

                    if (currentCounter > tailsCount)
                    {
                        tailsCount = currentCounter;
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }

            if (headsCount > tailsCount)
            {
                Console.WriteLine("H wins!");
            }
            else if (headsCount < tailsCount)
            {
                Console.WriteLine("T wins!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}
