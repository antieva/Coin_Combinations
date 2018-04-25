using System.Collections.Generic;
using System;

namespace CoinCombinationsApp
{
  public class CoinCombinations
  {
      public static Dictionary<string, int> CoinsCombinator(int num)
      {
          Dictionary<string, int> myCoins = new Dictionary<string, int>();
          if (num % 25 == 0) {
              myCoins["quarters"] = num/25;
          } else {
              myCoins["quarters"] = num/25;
              num -= (num/25)*25;
              if (num % 10 == 0) {
                  myCoins["dimes"] = num/10;
              } else {
                myCoins["dimes"] = num/10;
                num -= (num/10)*10;
                if (num % 5 == 0) {
                    myCoins["nickels"] = num/5;
                } else {
                  myCoins["nickels"] = num/5;
                  num -= (num/5)*5;
                  myCoins["pennies"] = num;
                }
              }
          }
          return myCoins;
      }
  }
}
