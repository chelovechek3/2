namespace _2
{
    internal class Order
    {
        public int OrderId { get; private set; }
        public string CustomerName { get; private set; }
        public List<string> Products { get; private set; }
        public decimal TotalCost { get; private set; }

        public Order(int orderId, string customerName)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Products = new List<string>();
            TotalCost = 0;
        }
        public void AddProduct(string product, decimal price)
        {
            Products.Add(product);
            TotalCost += price;
        }
    }
}