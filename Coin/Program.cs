using System;
using Coin.Models;

namespace Coin
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter an amount of cents to convert to the minimum number of coins:");
      string userInput = Console.ReadLine();
      int number = int.Parse(userInput);
      Counter newCounter = new Counter();
      string outputString = newCounter.CoinReturn(number);
      Console.WriteLine(outputString);
    }
  }
}