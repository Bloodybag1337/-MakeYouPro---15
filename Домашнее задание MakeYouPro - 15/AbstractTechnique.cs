using System;

namespace Inheritance
{
	public abstract class AbstractTechnique
	{
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int MemoryCapacity { get; set; }
        public int ScreenDiagonal { get; set; }
        public double Price { get; set; }

        public abstract void GiveMeShortInfo();

        public void GetAPrice() //метод реализуется одинаково для всех классов
        {
            Console.WriteLine("Сколько штук Вы хотите купить?");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n >= 5)
            {
                Price = n * Price - Price * (n / 100);
                Console.WriteLine($"Общая стоимость составит {Price} рублей");
            }
            else
                Console.WriteLine($"Общая стоимость составит {n * Price} рублей");
        }
    }
}

