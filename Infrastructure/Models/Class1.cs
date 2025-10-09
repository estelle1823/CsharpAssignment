namespace Infrastructure1.Models;
using Infrastructure1.Models;
public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? ArticleNumber { get; set; }
    public bool IsService { get; set; }
    public string ProductTitle { get; set; } = null!;
    public string? ProductDescription { get; set; } = null!;

    public string ProductCategory { get; set; } = null!;
}
