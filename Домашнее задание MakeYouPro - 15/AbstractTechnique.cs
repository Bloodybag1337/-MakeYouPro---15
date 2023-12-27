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
    }
}