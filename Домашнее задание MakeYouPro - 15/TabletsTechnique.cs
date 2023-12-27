using System;
namespace Inheritance
{
    public class TabletsTechnique : AbstractTechnique, IInformer
    {
        private int CameraResolution { get; set; }
        private bool StylusSupport { get; set; }

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
        {
            return obj is TabletsTechnique tablet &&
                Name == tablet.Name &&
                Manufacturer == tablet.Manufacturer &&
                Price == tablet.Price;
        }
    }
}

