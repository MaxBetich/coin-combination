namespace Coin.Models
{
  public class Counter
  {
    public string CoinReturn(int inputValue)
    {
      int dimes = (int)(inputValue/10);
      int dimesRemainder = inputValue%10;
      int nickels = (int)(dimesRemainder/5);
      int pennies = dimesRemainder%5;
      string output = $"{dimes} dime(s) and {nickels} nickel(s) and {pennies} pennies";
      return output;
    }
  }
}