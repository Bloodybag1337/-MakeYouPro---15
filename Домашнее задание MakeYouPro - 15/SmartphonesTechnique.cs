using System;
namespace Inheritance;

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

