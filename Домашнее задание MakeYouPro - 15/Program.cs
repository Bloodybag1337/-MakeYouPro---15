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
*/

using Inheritance;

Smartphones[] smartphone = new Smartphones[]
{
new Smartphones("iPhone", "Apple", 100000),
new Smartphones("Samsung", "Android", 85000),
new Smartphones("Xiaomi", "Android", 32000)
};

Tablets[] tablet = new Tablets[]
{
new Tablets("iPad", "Apple", 150000),
new Tablets("iPad", "Apple", 150000)
};

Notebooks[] notebook = new Notebooks[]
{
new Notebooks("Macbook", "Apple", 250000),
new Notebooks("Asus", "Asus", 75000),
new Notebooks("Dell", "Dell", 55000),
new Notebooks("HP", "HP", 80000)
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