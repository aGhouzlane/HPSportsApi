namespace HPSportsApi.Classes
{
  public class ItemQueryParameter : QueryParameters
  {
    public string Sku { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public string Name { get; set; }
  }
}