namespace DatabaseHandler.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string BasePizza { get; set; } = null!;
        public string Dought { get; set; } = null!;
        public string? Toppings { get; set; }
        public virtual Receipt ReceiptId { get; set; } = null!;
    }
}