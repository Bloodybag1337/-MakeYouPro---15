/*
Разработайте заготовку проекта интернет-магазина техники,
который продаёт смартфоны, планшеты и ноутбуки.

Все товары должны содержать в себе:
-название,
-производителя,
-количество памяти,
-диагональ экрана,
-цену.

При этом смартфоны и планшеты содержат информацию о разрешении камеры,
планшеты - информацию о поддержке стилуса,
ноутбуки - информацию о времени работы от аккумулятора.

Все товары содержат 2 метода:
-Получение короткой информации - который возвращает производителя, название и цену в текстовом виде;
-Получение цены, который получает на вход количество и возвращает цену с учетом оптовой скидки
(опт начинается с 5 и более позиций):
смартфоны - 7 %,
планшеты - 9 %,
ноутбуки - 5 %.

Все товары из одной категории можно сравнить между собой через метод Equals
Необходимо создать 4 класса - родительский товар и 3 класса товара отдельно.

Преобразуйте родительский класс из предыдущего задания в абстрактный, оптимальным на ваш взгляд образом.
*/

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