namespace Coin.Models
{
  public class Counter
  {
    public string CoinReturn(int inputValue)
    {
      string output = $"{inputValue} pennies";
      return output;
    }
  }
}