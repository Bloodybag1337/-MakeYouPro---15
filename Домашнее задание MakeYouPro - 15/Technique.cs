using System;
using System.Diagnostics;

namespace Inheritance
{
	public class Technique : AbstractTechnique
	{

		public Technique (string name, string manufacturer, double price)
		{
			Name = name;
			Manufacturer = manufacturer;
			Price = price;
		}

		public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Устройство {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
		}
	}

	public class SmartphonesTechnique : AbstractTechnique
    {
		public int CameraResolution { get; set; }

		public SmartphonesTechnique(string name, string manufacturer, double price)
		{
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Смартфон {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }
    }

	public class TabletsTechnique : AbstractTechnique
    {
		public int CameraResolution { get; set; }
		public bool StylusSupport { get; set; }

        public TabletsTechnique(string name, string manufacturer, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Планшет {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }

        public override bool Equals(object? obj)
			//проверка метода Equals на примере планшетов с одинаковыми данными
        {
			return obj is TabletsTechnique tablet &&
				Name == tablet.Name &&
                Manufacturer == tablet.Manufacturer &&
                Price == tablet.Price;
        }
    }

	public class NotebooksTechnique : AbstractTechnique
    {
        public int BatteryLife { get; set; }

        public NotebooksTechnique(string name, string manufacturer, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override void GiveMeShortInfo()
        {
            Console.WriteLine($"Ноутбук {Name} от бренда {Manufacturer}. Стоимость: {Price} рублей");
        }
    }
}