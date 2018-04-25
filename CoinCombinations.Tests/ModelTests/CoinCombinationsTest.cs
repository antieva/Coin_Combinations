using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoinCombinationsApp;
using System;

namespace CoinCombinationsApp.Tests
{
  [TestClass]
  public class CoinCombinationsTest
  {
      [TestMethod]
      public void CoinsCombinator_50_quarters2()
      {
          Dictionary<string, int> testOutput = new Dictionary<string, int>() {{"quarters", 2}};
          CollectionAssert.AreEqual(testOutput, CoinCombinations.CoinsCombinator(50));
      }

      [TestMethod]
      public void CoinsCombinator_60_quarters2dimes1()
      {
          Dictionary<string, int> testOutput = new Dictionary<string, int>() {{"quarters", 2}, {"dimes", 1}};
          CollectionAssert.AreEqual(testOutput, CoinCombinations.CoinsCombinator(60));
      }

      [TestMethod]
      public void CoinsCombinator_65_quarters2dimes1nickels1()
      {
          Dictionary<string, int> testOutput = new Dictionary<string, int>() {{"quarters", 2}, {"dimes", 1}, {"nickels", 1}};
          CollectionAssert.AreEqual(testOutput, CoinCombinations.CoinsCombinator(65));
      }

      [TestMethod]
      public void CoinsCombinator_68_quarters2dimes1nickels1pennies3()
      {
          Dictionary<string, int> testOutput = new Dictionary<string, int>() {{"quarters", 2}, {"dimes", 1}, {"nickels", 1}, {"pennies", 3}};
          CollectionAssert.AreEqual(testOutput, CoinCombinations.CoinsCombinator(68));
      }
  }
}
