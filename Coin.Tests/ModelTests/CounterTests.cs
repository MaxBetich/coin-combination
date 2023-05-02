using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin.Models;

namespace Coin.Tests
{
  [TestClass]
  public class CounterTests
  {
    Counter newCounter = new Counter();
    [TestMethod]
    public void CounterConstructor_CreatesInstanceOfCounter_Counter()
    {
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }

    [TestMethod]
    public void CoinReturn_ReturnsStringOfValues_String()
    {
      string coinReturn = newCounter.CoinReturn(4);
      Assert.AreEqual("0 dime(s) and 0 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn_ReturnsNicklesAndPennies_String()
    {
      string coinReturn = newCounter.CoinReturn(9);
      Assert.AreEqual("0 dime(s) and 1 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn_ReturnsDimes_String()
    {
      string coinReturn = newCounter.CoinReturn(19);
      Assert.AreEqual("1 dime(s) and 1 nickel(s) and 4 pennies", coinReturn);
    }
  }
}