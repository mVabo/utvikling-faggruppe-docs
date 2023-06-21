namespace BlazorApp.Models;

public class Mission
{
  public Planet destinationPlanet { get; set; }

  public Goods goods { get; set; }



  // Goods price with distance to planet calculated and multiplied with cargo capacity on the spaceship
  public int missionTotalValue { get; set; }



  public int spaceshipId { get; set; }



  public int missionTime { get; set; }
}