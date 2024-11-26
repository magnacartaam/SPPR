namespace WEB_253504_PATREBKA.Domain.Entities
{

  public class ElectricComponent
  {
    public required int Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public int? CategoryId { get; set; }

    public Uri? Image { get; set; }

    public required decimal Price { get; set; }
  }
}
