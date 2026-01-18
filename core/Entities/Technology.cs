namespace bt.Core.Entities;

public class Technology
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? ReleaseDate { get; set; }
    
    public int CategoryId { get; set; } // FK
    public Category? Category { get; set; } // Navigation property
}