using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название продукта:");
            string name = Console.ReadLine();
            name = name.Trim();
            name = name.ToUpper();

            Console.WriteLine("Введите количество единиц товара:");
            string amount = Console.ReadLine();
            amount = amount.Replace(".", ",");
            Convert.ToDecimal(amount);

            Console.WriteLine("Введите единицу измерения: \n(шт., кг, тонны, литры и тд)");
            string units = Console.ReadLine();
            units = units.ToLower();

            Console.WriteLine("Введите цену за единицу товара в долларах:");
            string price = Console.ReadLine();
            price = price.Replace(".", ".");
            Convert.ToDecimal(price);

            Console.Clear();

            Console.WriteLine("\n-------------------- \nВаши данные: ");
            Console.WriteLine("\nНазвание продкта: " + name + "\nКоличество: " + amount + units + "\nЦена: " + price + "$"); 

        }
    }
}
