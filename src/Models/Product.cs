using System.ComponentModel.DataAnnotations.Schema;

namespace BugStore.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Slug { get; set; } = null!;
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}