namespace BlazorApp.Models;

public class Spaceship
{
  public int ID { get; set; }

  public int PlayerId { get; set; }

  public string Name { get; set; }

  public string Description { get; set; }

  public string Type { get; set; }

  public string? ImageLink { get; set; }

  public int Speed { get; set; }

  public int Weapons { get; set; }

  public int Armor { get; set; }

  public int Capacity { get; set; }

  public int Durability { get; set; }

  public int Price { get; set; }

  public string Status { get; set; }

  public string CurrentCargoName { get; set; }

  public int CurrentCargoTotalValue { get; set; }

  public DateTime MissionStart { get; set; }

  public string CurrentPort { get; set; }

  public string TargetPort { get; set; }

  public int MissionTime { get; set; }

  public Spaceship(String Name, int PlayerId, String Description, String Type, String? ImageLink, int Speed, int Capacity, int Price)
  {
    this.Name = Name;
    this.PlayerId = PlayerId;
    this.Description = Description;
    this.Type = Type;
    this.ImageLink = ImageLink;
    this.Speed = Speed;
    this.Capacity = Capacity;
    this.Price = Price;
  }

  public Spaceship(String Name, String Description, String Type, String? ImageLink, int Speed, int Capacity, int Price)
  {
    this.Name = Name;
    this.PlayerId = 0;
    this.Description = Description;
    this.Type = Type;
    this.ImageLink = ImageLink;
    this.Speed = Speed;
    this.Capacity = Capacity;
    this.Price = Price;
  }

  public Spaceship()
  {
    this.Name = "";
    this.PlayerId = 0;
    this.Description = "";
    this.Type = "";
    this.ImageLink = "";
    this.Speed = 0;
    this.Capacity = 0;
    this.Price = 0;
  }
}
