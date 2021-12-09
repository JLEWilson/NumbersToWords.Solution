using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class WordifierTests
  {
    [TestMethod]
    public void ChangeToWords_ReturnWordsForInt_five()
    {
      string number = "5";
      string numberAsString = Wordifier.ChangeToWords(number);
      Assert.AreEqual("five", numberAsString);
    }

    [TestMethod]
    public void ChangeToWords_ReturnWordsForInt_fifteen()
    {
      string number = "15";
      string numberAsString = Wordifier.ChangeToWords(number);
      Assert.AreEqual("fifteen", numberAsString);
    }

    [TestMethod]
    public void ChangeToWords_ReturnWordsForIntAbove20_fiftyfive()
    {
      string number = "55";
      string numberAsString = Wordifier.ChangeToWords(number);
      Assert.AreEqual("fifty-five", numberAsString);
    }
  }
}