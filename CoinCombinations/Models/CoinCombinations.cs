using System.Collections.Generic;
using System;

namespace CoinCombinationsApp
{
  public class CoinCombinations
  {
      public static Dictionary<string, int> CoinsCombinator(int num)
      {
          Dictionary<string, int> myCoins = new Dictionary<string, int>();

          myCoins["quarters"] = num/25;
          num -= (num/25)*25;
          myCoins["dimes"] = num/10;
          num -= (num/10)*10;
          myCoins["nickels"] = num/5;
          num -= (num/5)*5;
          myCoins["pennies"] = num;

          return myCoins;
      }
  }
}
