namespace BlazorApp.Interfaces;

using BlazorApp.Models;

public interface IDatabaseService
{
  Task<List<Player>> GetPlayers();
  Task<Player?> GetUniquePlayer(int Id);
  Task<int> AddPlayer(Player player);
  Task<int> WithdrawMoney(Player player, int amount);
  Task<List<Spaceship>> GetSpaceships(String userId);
  Task<int> AddSpaceship(Spaceship spaceship);
  Task<Boolean> SellSpaceship(Spaceship spaceship);
}