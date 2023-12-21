using Inheritance;

SmartphonesTechnique[] smartphone = new SmartphonesTechnique[]
{
new SmartphonesTechnique("iPhone", "Apple", 100000),
new SmartphonesTechnique("Samsung", "Android", 85000),
new SmartphonesTechnique("Xiaomi", "Android", 32000)
};

TabletsTechnique[] tablet = new TabletsTechnique[]
{
new TabletsTechnique("iPad", "Apple", 150000),
new TabletsTechnique("iPad", "Apple", 150000)
};

NotebooksTechnique[] notebook = new NotebooksTechnique[]
{
new NotebooksTechnique("Macbook", "Apple", 250000),
new NotebooksTechnique("Asus", "Asus", 75000),
new NotebooksTechnique("Dell", "Dell", 55000),
new NotebooksTechnique("HP", "HP", 80000)
};

for (int i = 0; i < smartphone.Length; i++)
{
    smartphone[i].GiveMeShortInfo();
    smartphone[i].GetAPrice();
    Console.WriteLine();
}

for (int i = 0; i < tablet.Length; i++)
{
    tablet[i].GiveMeShortInfo();
    tablet[i].GetAPrice();
    Console.WriteLine();
}

if (tablet[0].Equals(tablet[1]))
    Console.WriteLine("Элементы равны\n");
else
    Console.WriteLine("Элементы не равны\n");

for (int i = 0; i < notebook.Length; i++)
{
    notebook[i].GiveMeShortInfo();
    notebook[i].GetAPrice();
    Console.WriteLine();
}

Console.ReadKey();