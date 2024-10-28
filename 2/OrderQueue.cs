namespace _2
{
    internal class OrderQueue
    {
        private Queue<Order> orderQueue;
        private Stack<Order> completedOrders;
        private Dictionary<int, string> orderStatuses;
        public OrderQueue()
        {
            orderQueue = new Queue<Order>();
            completedOrders = new Stack<Order>();
            orderStatuses = new Dictionary<int, string>();
        }
        public void AddOrder(Order order)
        {
            orderQueue.Enqueue(order);
            orderStatuses[order.OrderId] = "новый";
        }
        public Order ProcessNextOrder()
        {
            if (orderQueue.Count > 0)
            {
                Order nextOrder = orderQueue.Dequeue();
                orderStatuses[nextOrder.OrderId] = "обрабатывается";
                return nextOrder;
            }
            return null;
        }
        public void CompleteOrder(Order order)
        {
            orderStatuses[order.OrderId] = "завершён";
            completedOrders.Push(order);
        }
        public string GetOrderStatus(int orderId)
        {
            return orderStatuses.ContainsKey(orderId) ? orderStatuses[orderId] : "Заказ не найден";
        }
    }
}
