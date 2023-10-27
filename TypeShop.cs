//Додайте до другого завдання реалізацію деструктора. Напишіть код для тестування нових можливостей.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_4
{
    internal class TypeShop
    {
        public string Food { get; set; }
        public string Household { get; set; }
        public string Clothing { get; set; }
        public string Shoes { get; set; }

        public void ShowFood()
        {
            Console.WriteLine(Food);
        }
        public void ShowHousehold()
        {
            Console.WriteLine(Household);
        }
        public void ShowClothing()
        {
            Console.WriteLine(Clothing);
        }
        public void ShowShoes()
        {
            Console.WriteLine(Shoes);
        }
    }
}
