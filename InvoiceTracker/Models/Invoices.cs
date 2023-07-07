namespace InvoiceTracker.Models
{
    public class Invoices
    {
        public int InvoiceId { get; set; }
        public string CustomerName { get; set; } = null!;
        public int CustomerPhoneNumber { get; set; }
        public Employee Employee { get; set; } = null!;
        public string PartDesc { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
