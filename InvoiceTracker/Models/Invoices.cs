using System.ComponentModel.DataAnnotations;

namespace InvoiceTracker.Models;

public class Invoice
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string? CustomerName { get; set; } 
    public int CustomerPhoneNumber { get; set; }
    public string? Email { get; set; } 
    [Required]
    [StringLength(500)]
    public string? PartDesc { get; set; } 
    public DateTime Created { get; set; }
    public DateTime? Completed { get; set; }
}

