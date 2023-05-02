namespace Coin.Models
{
  public class Counter
  {
    public string CoinReturn(int inputValue)
    {
      int nickels = (int)(inputValue/5);
      int pennies = inputValue%5;
      string output = $"{nickels} nickel(s) and {pennies} pennies";
      return output;
    }
  }
}