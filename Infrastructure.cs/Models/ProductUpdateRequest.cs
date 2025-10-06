namespace Infrastructure.cs.Models;

public class ProductUpdateRequest
{
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductName { get; set; } = null!;
    public string? Description { get; set; }
    public string Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}

