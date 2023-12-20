using System;
using System.Diagnostics;

namespace Inheritance
{
	public class Technique //родительский класс
	{
		public string Name { get; set; }
		public string Manufacturer { get; set; }
		public int MemoryCapacity { get; set; }
		public int ScreenDiagonal { get; set; }
		public double Price { get; set; }

		public Technique (string name, string manufacturer, double price)
		{
			Name = name;
			Manufacturer = manufacturer;
			Price = price;
		}

		public virtual void GiveMeShortInfo()
        //virtual - потому что в наследниках вместо слова "устройство" будет его название
		//(смартфон, ноутбук или планшет)
        {
            Console.WriteLine($"Устройство {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
		}

		public void GetAPrice()
		{
			Console.WriteLine("Сколько штук Вы хотите купить?");
			double n = Convert.ToDouble(Console.ReadLine());
			if (n >= 5)
			{
				Price = n * Price - Price * (n/100);
				Console.WriteLine($"Общая стоимость составит {Price} рублей");
			}
			else
				Console.WriteLine($"Общая стоимость составит {n * Price} рублей");
		}
	}

	public class Smartphones : Technique //класс-наследник
    {
		public int CameraResolution { get; set; }

		public Smartphones (string name, string manufacturer, double price) :
			base (name, manufacturer, price) //наследование конструктора от базового класса
		{

		}

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Смартфон {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }
    }

	public class Tablets : Technique //класс-наследник
    {
		public int CameraResolution { get; set; }
		public bool StylusSupport { get; set; }

        public Tablets (string name, string manufacturer, double price) :
			base(name, manufacturer, price) //наследование конструктора от базового класса
        {

        }

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Планшет {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }

        public override bool Equals(object? obj)
			//проверка метода Equals на примере планшетов с одинаковыми данными
        {
			return obj is Tablets tablet &&
				Name == tablet.Name &&
                Manufacturer == tablet.Manufacturer &&
                Price == tablet.Price;
        }
    }

	public class Notebooks : Technique //класс-наследник
    {
        public int BatteryLife { get; set; }

        public Notebooks (string name, string manufacturer, double price) :
			base(name, manufacturer, price) //наследование конструктора от базового класса
        {

        }

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Ноутбук {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }
    }
}