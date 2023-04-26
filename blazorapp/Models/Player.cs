namespace BlazorApp.Models;

public class Player
{
  public int ID { get; set; }

  public String? Name { get; set; }

  public int Balance { get; set; }

  public String? HomePlanet { get; set; }

  public DateTime Created { get; set; }

  public Player()
  {
    ID = 0;
    Name = "";
    Balance = 2000;
    HomePlanet = "";
    Created = DateTime.MinValue;
  }
}