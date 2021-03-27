using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_ColectionList2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inventory = new List<char>();
            string userInput = string.Empty;
            bool exit = false;

            while (exit == false)
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Показать содержимое рюкзака":
                        foreach (char item in inventory)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();
                        break;
                    case "Добавить предмет в рюкзак":
                        inventory.Add('$');
                        break;
                    case "Удалить предмет из рюкзака":
                        inventory.Remove('$');
                        break;
                    case "Выйти из программы":
                        exit = true;
                        break;
                }
            }
        }
    }
}
