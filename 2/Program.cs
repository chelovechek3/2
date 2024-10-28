namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderQueue orderQueue = new OrderQueue();
            Order order1 = new Order(1, "Василевский Данил");
            order1.AddProduct("Товар A", 100);
            order1.AddProduct("Товар B", 150);
            orderQueue.AddOrder(order1);
            Order processingOrder = orderQueue.ProcessNextOrder();
            if (processingOrder != null)
            {
                Console.WriteLine($"Обработка заказа ID: {processingOrder.OrderId}, Клиент: {processingOrder.CustomerName}");           
            }
        }
    }
}
