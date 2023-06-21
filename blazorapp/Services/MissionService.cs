namespace BlazorApp.Services;
using BlazorApp.Models;

public class MissionService
{
  private List<Goods> listGoods;

  private SolarSystemService _solarsystemService;

  public MissionService()
  {
    InitializeGoods();
    _solarsystemService = new SolarSystemService();
  }

  private void InitializeGoods()
  {
    listGoods = new List<Goods>();

    // Initialize goods
    listGoods.Add(new Goods("Food", 100));
    listGoods.Add(new Goods("Medical equipment", 150));
    listGoods.Add(new Goods("Contraband", 200));
    listGoods.Add(new Goods("Secret technology", 250));
  }




  public List<Mission> GiveListOfPossibleMissions(Spaceship currentSpaceship)
  {
    List<Planet> listOfAllPlanets = _solarsystemService.planets;

    List<Planet> validDestinationPlanets = listOfAllPlanets.Where(p => p.Name != currentSpaceship.CurrentPort).ToList();

    List<Mission> listPossibleMissions = new List<Mission>();


    foreach (Planet p in validDestinationPlanets)
    {
      Random random = new Random();
      int goodsIndex = random.Next(0, listGoods.Count);

      var goodsForThisPlanet = listGoods[goodsIndex];

      Mission tempMission = new Mission();
      tempMission.destinationPlanet = p;
      tempMission.goods = goodsForThisPlanet;

      // Distance to the planet
      int distanceToPlanet = (int)_solarsystemService.FindDistance(currentSpaceship.CurrentPort, p.Name);

      // Random goods value
      int randomGoodsValue = goodsForThisPlanet.GiveRandomValueFromBaseValue();

      // Calculate missionValue for 1 goods of this type
      int valueGoodsWithDistanceIncluded = randomGoodsValue + (randomGoodsValue * distanceToPlanet / 100);

      // Calculate total mission value based on spaceship capacity
      int missionTotalValue = valueGoodsWithDistanceIncluded * currentSpaceship.Capacity;

      // Set total mission value
      tempMission.missionTotalValue = missionTotalValue;

      // Set spaceship id
      tempMission.spaceshipId = currentSpaceship.ID;

      // Set mission time
      tempMission.missionTime = (int)(distanceToPlanet / currentSpaceship.Speed);

      listPossibleMissions.Add(tempMission);
    }

    return listPossibleMissions;
  }
}