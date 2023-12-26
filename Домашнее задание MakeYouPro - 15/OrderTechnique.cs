using System;
/*
Внесите следующие изменения в проект онлайн-магазина из позапрошлого блока:
Добавьте класс заказа, который будет содержать в себе:
имя заказчика,
дату создания,
позиции заказа и их количество,
метод расчета суммы, который будет возвращать сумму всего заказа.
*/
namespace Inheritance;

public class OrderTechnique
{
    public static string ClientName { get; set; }
    public static string OrderDate { get; set; }
    public double Count { get; set; }

	public OrderTechnique(string clientName, string orderDate, double count)
	{
        ClientName = clientName;
        OrderDate = orderDate;
        Count = count;
	}

	public static void CountSum()
    {
        AbstractTechnique[][] abstractTechnique = new AbstractTechnique[3][];

        abstractTechnique[0] = new SmartphonesTechnique[]
        {
            new SmartphonesTechnique("iPhone", "Apple", 100000),
            //new SmartphonesTechnique("Samsung", "Android", 85000),
            //new SmartphonesTechnique("Xiaomi", "Android", 32000)
        };
        abstractTechnique[1] = new TabletsTechnique[]
        {
            new TabletsTechnique("iPad", "Apple", 150000),
            //new TabletsTechnique("iPad", "Apple", 150000)
        };
        abstractTechnique[2] = new NotebooksTechnique[]
        {
            new NotebooksTechnique("Macbook", "Apple", 250000),
            //new NotebooksTechnique("Asus", "Asus", 75000),
            //new NotebooksTechnique("Dell", "Dell", 55000),
            //new NotebooksTechnique("HP", "HP", 80000)
        };

        double sum = 0;
        for (int i = 0; i < abstractTechnique.Length; i++)
        {
            for (int j = 0; j < abstractTechnique[i].Length; j++)
            {
                abstractTechnique[i][j].GiveMeShortInfo();
                Console.WriteLine("Сколько штук Вы хотите купить?");
                double Count = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                if (Count >= 5)
                {
                    abstractTechnique[i][j].Price = Count * abstractTechnique[i][j].Price - abstractTechnique[i][j].Price * (Count / 100);
                    sum += abstractTechnique[i][j].Price;
                }
                else
                {
                    abstractTechnique[i][j].Price *= Count;
                    sum += abstractTechnique[i][j].Price;
                }
            }
        }
        Console.WriteLine($"{ClientName}, итоговая стоимость Вашего заказа от {OrderDate} составляет {sum} рублей");
    }
}