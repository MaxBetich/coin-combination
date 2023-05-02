using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin.Models;

namespace Coin.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void CounterConstructor_CreatesInstanceOfCounter_Counter()
    {
      Counter newCounter = new Counter();
      Assert.AreEqual(typeof(Counter), newCounter.GetType());
    }

    
  }
}