using System.ComponentModel.DataAnnotations;

namespace InvoiceTracker.Models;

public class Invoice
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? CustomerName { get; set; }

    [Required]
    [RegularExpression(@"^[0-9]+$")]
    [StringLength(10)]
    public string? CustomerPhoneNumber { get; set; }

    [Required]
    [RegularExpression(@"^[A-Za-z0-9]+@[A-Za-z]+\.[a-zA-Z][a-zA-Z][a-zA-Z]$")]
    public string? Email { get; set; } 

    [Required]
    [StringLength(500)]
    public string? PartDesc { get; set; } 

    public DateTime Created { get; set; }

    public DateTime? Completed { get; set; }
}

