namespace Coin.Models
{
  public class Counter
  {
    public string CoinReturn(int inputValue)
    {
      int quarters = (int)(inputValue/25);
      int quartersRemainder = inputValue%25;
      int dimes = (int)(quartersRemainder/10);
      int dimesRemainder = quartersRemainder%10;
      int nickels = (int)(dimesRemainder/5);
      int pennies = dimesRemainder%5;
      string output = $"{quarters} quarter(s) and {dimes} dime(s) and {nickels} nickel(s) and {pennies} pennies";
      return output;
    }

    public string CoinReturn2(int inputValue)
    {
      int quarters = (int)(inputValue/25);
      if (quarters > 2)
      {
        quarters = 2;
      }
      int quartersRemainder = inputValue -(quarters*25);
      int dimes = (int)(quartersRemainder/10);
      if (dimes > 2)
      {
        dimes = 2;
      }
      int dimesRemainder = quartersRemainder -(dimes*10);
      int nickels = (int)(dimesRemainder/5);
      if (nickels > 2)
      {
        nickels = 2;
      }
      int pennies = dimesRemainder -(nickels*5);
      string output = $"{quarters} quarter(s) and {dimes} dime(s) and {nickels} nickel(s) and {pennies} pennies";
      return output;
    }
  }
}