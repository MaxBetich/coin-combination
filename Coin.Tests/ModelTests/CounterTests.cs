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
      Assert.AreEqual("4 pennies", coinReturn);
    }
  }
}