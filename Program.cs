using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свое имя:");
            string name = Console.ReadLine();
            name = name.Trim();

            Console.WriteLine("введите свой возраст:");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("введите свой адрес:");
            string adress = Console.ReadLine();
            adress = adress.Trim();
            adress = adress.Replace(".", ",");

            Console.WriteLine("введите свой рост:");
            string height = Console.ReadLine();
            height = height.Replace(".", ",");
            Convert.ToSingle(height);

            Console.WriteLine("введите свой вес:");
            string weight = Console.ReadLine();
            weight = weight.Replace(".", ",");
            Convert.ToSingle(weight);

            Console.WriteLine("введите свой номер телефона: (без +380)");
            string phone = Console.ReadLine();
           
            Console.WriteLine("\n-------------------- \nВаши данные: ");
            Console.WriteLine("Имя: " + name + "\nВозраст: " + age + " года" + "\nАдрес: " + adress  + "\nРост: " + height + " см" + "\nВес: " + weight + " кг" + "\nНомер телефона: +380" + phone);
           







        }  
    }
}
