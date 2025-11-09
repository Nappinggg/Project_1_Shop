namespace ShopApp
{
    class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double TotalPrice { get; set; }
        public bool IsCompleted { get; set; }
    }
}
