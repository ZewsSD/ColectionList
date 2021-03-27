using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_ColectionList3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string userInput = string.Empty;
            bool exit = false;
            int sum = 0;
            bool isValidInput = false;
            int number = 0;

            while (exit == false)
            {
                userInput = Console.ReadLine();

                switch (isValidInput = int.TryParse(userInput, out number))
                {
                    case true:
                        numbers.Add(number);
                        break;
                    case false:
                        if (userInput == "sum")
                        {
                            foreach (int item in numbers)
                            {
                                Console.Write(item + " ");
                            }

                            Console.WriteLine();

                            foreach (int item in numbers)
                            {
                                sum += item;
                            }

                            Console.WriteLine(sum);
                        }
                        if (userInput == "exit")
                        {
                            exit = true;
                        }
                        break;
                }
            }
        }
    }
}
