namespace cash
{
    public class Receipt
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public byte[] Image { get; set; }
    }
}