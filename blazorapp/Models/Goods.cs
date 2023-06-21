namespace BlazorApp.Models;

public class Goods
{
  public string name { get; set; }



  public int baseValue { get; set; }



  public Goods(string name, int baseValue)
  {
    this.name = name;
    this.baseValue = baseValue;
  }



  public int GiveRandomValueFromBaseValue()
  {
    Random random = new Random();
    int extraPercent = random.Next(0, 100);



    // Will return at the minimum the baseValue with a possibility to up to double of baseValue
    // This is for 1 goods. the randomValueOfGoods will then be multiplied with storage capacity on spaceship
    int randomValueOfGoods = (int)(baseValue + (baseValue * extraPercent / 100));



    return randomValueOfGoods;
  }
}