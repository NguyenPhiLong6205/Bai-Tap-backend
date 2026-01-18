namespace bt.Core.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    // Quan hệ: Một danh mục có nhiều công nghệ
    public ICollection<Technology> Technologies { get; set; } = new List<Technology>();
}