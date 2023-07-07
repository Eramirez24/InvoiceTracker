namespace InvoiceTracker.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;

        public List<Invoices> Invoices { get; set; } = new List<Invoices>();
    }
}
