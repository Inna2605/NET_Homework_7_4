//Додайте до другого завдання реалізацію деструктора. Напишіть код для тестування нових можливостей.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Shop shop = new Shop();

            Console.Write("Введіть назву магазину: ");
            shop.Name = Console.ReadLine();

            Console.Write("Введіть адресу магазину: ");
            shop.Address = Console.ReadLine();

            shop.InputTypeShop();
            shop.Show();

            //shop.Dispose();//безпосередньо виклик методу Dispose() через об'єкт

            using (shop)
            {
                Console.WriteLine("\n\n\nВідпрацювання конструкції using");
            }

            Console.ReadLine();
        }
    }
}
