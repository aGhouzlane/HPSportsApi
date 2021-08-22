namespace HPSportsApi.Models
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public decimal Price { get; set; }
    public string Sku { get; set; }
  }
}