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
}