using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Wordifier
  {
    public static Dictionary<int, string> sub10 = new Dictionary<int, string>()
    {
      {1, "one"},{2 , "two"},{3, "three"},{4, "four"},{5, "five"},{6, "six"},{7, "seven"},{8, "eight"},{9, "nine"}
    };
    public static Dictionary<int, string> sub20 = new Dictionary<int, string>()
    {
      {0, "ten"},{1, "eleven"},{2, "twelve"},{3, "thirteen"},{4, "fourteen"},{5, "fifteen"},{6, "sixteen"},{7, "seventeen"},{8, "eighteen"},{9, "nineteen"}
    };
    
    public static Dictionary<int, string> sub100 = new Dictionary<int, string>()
    {
      {2, "twenty"},{3, "thirty"},{4, "forty"},{5, "fifty"},{6, "sixty"},{7, "seventy"},{8, "eighty"},{9, "ninety"}
    };
        public static string ChangeToWords(string input)
    {
      List<string> outputStringList = new List<string>{};
      string outputString = "";
      char[] charArr = input.ToCharArray();
      for(int index = charArr.Length - 1; index >= 0; index--) 
      {
        if (charArr.Length == 2 && charArr[0] == '1')
        {
          Console.WriteLine("First block");
          outputString = (sub20[int.Parse(charArr[1].ToString())]);
          break;
        } 
        else if (charArr.Length == 1)
        {
          Console.WriteLine("Second block");
          outputString = sub10[int.Parse(charArr[0].ToString())];
        } 
        else if (charArr.Length == 2 && charArr[0] != '1')
        {
          Console.WriteLine("Third block");
          outputStringList.Add(sub100[int.Parse(charArr[1].ToString())]);
          outputStringList.Add(sub10[int.Parse(charArr[0].ToString())]);
          outputString = string.Join("-", outputStringList);
          break;
        }
      }
      
      return outputString;
    }
  }
}


