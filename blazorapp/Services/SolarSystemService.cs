namespace BlazorApp.Services;

using BlazorApp.Models;

public class SolarSystemService
{
  public List<Planet> planets;
  private Dictionary<(string, string), int> distances;

  public SolarSystemService()
  {
    planets = new List<Planet>();

    PopulateSolarSystem();

    InitiateDistances();
  }

  public void PopulateSolarSystem()
  {
    planets.Add(new Planet("Ceres spaceport", "Warm climate with high chances of solar winds"));
    planets.Add(new Planet("Tycho station", "Popular space station with many crews looking for their next score"));
    planets.Add(new Planet("Void city", "Called void for a reason, holds dangerous creatures"));
    planets.Add(new Planet("Latona platform", "A rich mans planet with a strong defence system that sometimes missfires"));
    planets.Add(new Planet("Phoebe depot", "Depot swarming with space-pirates"));
  }

  public void InitiateDistances()
  {
    distances = new Dictionary<(string, string), int>
    {
      { ("Tycho station", "Void city"), 50 },
      { ("Tycho station", "Ceres spaceport"), 50 },
      { ("Tycho station", "Latona platform"), 200 },
      { ("Tycho station", "Phoebe depot"), 150 },
      { ("Void city", "Latona platform"), 150 },
      { ("Void city", "Ceres spaceport"), 50 },
      { ("Void city", "Phoebe depot"), 100 },
      { ("Ceres spaceport", "Latona platform"), 100 },
      { ("Ceres spaceport", "Phoebe depot"), 50 },
      { ("Phoebe depot", "Latona platform"), 50 },
    };
  }

  public int? FindDistance(String planet1, String planet2)
  {
    if (distances.TryGetValue((planet1, planet2), out var distance1))
    {
      return distance1;
    }

    if (distances.TryGetValue((planet2, planet1), out var distance2))
    {
      return distance2;
    }

    return null;
  }
}