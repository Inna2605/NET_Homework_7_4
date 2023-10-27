//Додайте до другого завдання реалізацію деструктора. Напишіть код для тестування нових можливостей.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET_Homework_7_4
{
    internal class Shop:TypeShop, IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public TypeShop TypeShop;
        public void InputTypeShop()
        {
            Console.WriteLine("\nОберіть тип магазину:\n" +
                "1. Продовольчий;\n" +
                "2. Господарський;\n" +
                "3. Одягу;\n" +
                "4. Взуття.\n");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Food = "Продовольчий";
                        typeShop.ShowFood();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Household = "Господарський";
                        typeShop.ShowHousehold();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Clothing = "Одягу";
                        typeShop.ShowClothing();
                        break;
                    }
                case 4:
                    {
                        Console.Write("Магазин ");
                        TypeShop typeShop = new TypeShop();
                        typeShop.Shoes = "Взуття";
                        typeShop.ShowShoes();
                        break;
                    }
            }
        }
        public void Show()
        {
            Console.Write($"Назва магазину: {Name}\nАдреса магазину: {Address}");
        }
        public void Dispose()
        {
            Console.WriteLine("\n\nВідпрацювання метода Dispose()");
        }
        ~Shop()
        {
            Console.WriteLine("Відпрацювання фіналізатора.");
            Thread.Sleep(60000);//Затримка часу спрацювання фіналізатора
        }
    }
}
