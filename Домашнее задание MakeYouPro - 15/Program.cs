using System;
using System.Diagnostics;
using Inheritance;

Console.WriteLine("Как Вас зовут?");
OrderTechnique.ClientName = Console.ReadLine();
Console.WriteLine("Укажите дату Вашего заказа:");
OrderTechnique.OrderDate = Console.ReadLine();
Console.WriteLine();
OrderTechnique.CountSum();
Console.ReadKey();