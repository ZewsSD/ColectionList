using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_ColectionList1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 4, 1, 3, 4, };
            int result = 0;

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (int item in numbers)
            {
                result += item;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
