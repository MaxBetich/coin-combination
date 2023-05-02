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
      Assert.AreEqual("0 quarter(s) and 0 dime(s) and 0 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn_ReturnsNicklesAndPennies_String()
    {
      string coinReturn = newCounter.CoinReturn(9);
      Assert.AreEqual("0 quarter(s) and 0 dime(s) and 1 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn_ReturnsDimes_String()
    {
      string coinReturn = newCounter.CoinReturn(19);
      Assert.AreEqual("0 quarter(s) and 1 dime(s) and 1 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn_ReturnsQuarters_String()
    {
      string coinReturn = newCounter.CoinReturn(44);
      Assert.AreEqual("1 quarter(s) and 1 dime(s) and 1 nickel(s) and 4 pennies", coinReturn);
    }

    [TestMethod]
    public void CoinReturn2_ReturnsPennies_String()
    {
      string coinReturn2 = newCounter.CoinReturn2(4);
      Assert.AreEqual("0 quarter(s) and 0 dime(s) and 0 nickel(s) and 4 pennies", coinReturn2);
    }

    // [TestMethod]
    // public void CoinReturn2_ReturnsTwoNickels_String()
    // {
    //   string coinReturn2 = newCounter.CoinReturn2(15);
    //   Assert.AreEqual("0 quarter(s) and 0 dime(s) and 2 nickel(s) and 5 pennies", coinReturn2);
    // }

    [TestMethod]
    public void CoinReturn2_ReturnsTwoDimes_String()
    {
      string coinReturn2 = newCounter.CoinReturn2(45);
      Assert.AreEqual("0 quarter(s) and 2 dime(s) and 2 nickel(s) and 15 pennies", coinReturn2);
    }
  }
}