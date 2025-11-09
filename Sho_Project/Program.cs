using System;
using System.Collections.Generic;

namespace ShopApp
{
    class Program
    {
        static void PrintProduct(Product p)
        {
            Console.WriteLine("\n\t\t |Інформацiя товару|\n");
            Console.WriteLine($"{"Назва:",-20} {p.Name}");
            Console.WriteLine($"{"ID:",-20} {p.Id}");
            Console.WriteLine($"{"Цiна:",-20} {p.Price}");
            Console.WriteLine($"{"Статус:",-20} {(p.Available ? "Є в наявностi" : "Немає в нявності")}");
        }

        static void PrintCustomer(Customer c)
        {
            Console.WriteLine("\n\t\t |Інформацiя клiєнта|\n");
            Console.WriteLine($"{"Iм'я:",-20} {c.FullName}");
            Console.WriteLine($"{"Вiк:",-20} {c.Age}");
            Console.WriteLine($"{"Баланс:",-20} {c.Balance}");
            Console.WriteLine($"{"Статус:",-20} {(c.IsRegular ? "Постiйний" : "Новий")}");
        }

        static void PrintOrder(Order o)
        {
            Console.WriteLine("\n\t\t |Iнформацiя про замовлення|\n");
            Console.WriteLine($"{"ID замовлення:",-20} {o.OrderId}");
            Console.WriteLine($"{"Клiєнт:",-20} {o.CustomerName}");
            Console.WriteLine($"{"Сума:",-20} {o.TotalPrice}");
            Console.WriteLine($"{"Статус:",-20} {(o.IsCompleted ? "Виконано" : "В процесi")}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Використання класу Product
            Product ebook = new Product { Id = 101, Name = "Амазон Кіндел", Price = 12999.99, Available = true };
            PrintProduct(ebook);

            // Використання класу Customer
            Customer customer = new Customer { FullName = "Вася Пупкін", Age = 25, Balance = 3559.90, IsRegular = false };
            PrintCustomer(customer);

            // Використання класу Order
            Order newOrder = new Order { OrderId = 1, CustomerName = customer.FullName, TotalPrice = ebook.Price, IsCompleted = false };
            PrintOrder(newOrder);

            // Масив
            int[] prices = { 33000, 44950, 43200 };
            Console.Write("\nЦiни: ");
            foreach (int p in prices)
                Console.Write(p + " ");
            Console.WriteLine();

            // Список
            List<string> clients = new List<string> { "Влад", "Уляна" };
            clients.Add("Аполінарія");
            Console.Write("Клiєнти: ");
            foreach (string c in clients)
                Console.Write(c + " ");
            Console.WriteLine();

            // Черга
            Queue<string> queueClients = new Queue<string>();
            queueClients.Enqueue("Клiєнт 1");
            queueClients.Enqueue("Клiєнт 2");
            Console.WriteLine("Перший у черзi: " + queueClients.Peek());
            queueClients.Dequeue();
            Console.WriteLine("Тепер перший: " + queueClients.Peek());

            // Стек
            Stack<string> actions = new Stack<string>();
            actions.Push("Увiйшов у систему");
            actions.Push("Зробив замовлення");
            Console.WriteLine("Остання дiя: " + actions.Peek());

            // Словник
            Dictionary<int, string> productDB = new Dictionary<int, string>
            {
                { 1, "Навушники" },
                { 2, "Смартфон" },
                { 3, "Ноутбук" }
            };

            Console.WriteLine("\nБаза товарiв:");
            foreach (var p in productDB)
                Console.WriteLine($"{p.Key} -> {p.Value}");

            // Множина
            HashSet<string> orders = new HashSet<string> { "Замовлення1", "Замовлення2", "Замовлення3" };
            Console.Write("\nУнiкальнi замовлення: ");
            foreach (string o in orders)
                Console.Write(o + " ");
            Console.WriteLine();
        }
    }
}
