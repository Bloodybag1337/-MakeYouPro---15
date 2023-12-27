using System;
using Inheritance;
using System.Diagnostics;
using System.Xml.Linq;

namespace Inheritance
{
    public class NotebooksTechnique : AbstractTechnique, IInformer
    {
        private int BatteryLife { get; set; }

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

