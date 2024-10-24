using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;

namespace ArticleManagement
{
    public class Article
    {
        public string Code { get; set; }    
        public string Name { get; set; } 
        public decimal Price { get; set; }

        public Article(string code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }
    public struct RequestItem
    {
        public Article Product { get; set; }
        public int Quantity { get; set; }
        public RequestItem(Article product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public decimal TotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
    public struct Client
    {
        public string ClientCode { get; set; }        
        public string FullName { get; set; }     
        public string Address { get; set; }         
        public string Phone { get; set; }          
        public List<RequestItem> PurchasedItems { get; set; }
        public Client(string clientCode, string fullName, string address, string phone)
        {
            ClientCode = clientCode;
            FullName = fullName;
            Address = address;
            Phone = phone;
            PurchasedItems = new List<RequestItem>();
        }

        public decimal TotalOrderAmount
        {
            get
            {
                decimal total = 0;
                foreach (var item in PurchasedItems)
                {
                    total += item.TotalPrice();
                }
                return total;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article("001", "Laptop", 1200.50m);
            Article article2 = new Article("002", "Mouse", 25.99m);
            RequestItem requestItem1 = new RequestItem(article1, 1);
            RequestItem requestItem2 = new RequestItem(article2, 2);
            Client client = new Client("C001", "Иванов Иван Иванович", "ул. Примерная, д. 1", "+7 900 000 00 00");
            client.PurchasedItems.Add(requestItem1);
            client.PurchasedItems.Add(requestItem2);

            Console.WriteLine("\nСписок купленных товаров:");
            foreach (var item in client.PurchasedItems)
            {
                Console.WriteLine($"- {item.Product.Name} (Код: {item.Product.Code}) - Количество: {item.Quantity}, Цена за единицу: {item.Product.Price} руб., Общая стоимость: {item.TotalPrice()} руб.");
            }
            Console.WriteLine($"Номер заказа: {client.ClientCode}");
            Console.WriteLine($"Клиент: {client.FullName}");
            Console.WriteLine($"Адрес клиента: { client.Address}");
            Console.WriteLine($"Номер телефона клиента{ client.Phone}");
            Console.WriteLine($"Общая сумма заказов: {client.TotalOrderAmount} руб.");
        }
    }
}