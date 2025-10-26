using System.ComponentModel.DataAnnotations.Schema;

namespace BugStore.Models;

public class OrderLine
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    
    public int Quantity { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
}