using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> food = new Dictionary<string, int>();
            food.Add("Cheese", 1);
            food.Add("Meet", 2);
            food.Add("Water", 3);
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();

            if (food.ContainsKey(key))
            {
                Console.WriteLine(food[key]);
            }
            else 
            {
                Console.WriteLine("Свопадений нет");
            }
        }
    }
}