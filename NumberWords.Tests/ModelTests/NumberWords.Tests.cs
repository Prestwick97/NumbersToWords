using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberWords.Models;

namespace NumberWords.Test
{
  [TestClass]
  public class NumberWordsTests
  {
    
    [TestMethod]
    public void OnesName_RecieveLetterNameOfNumber_String()
    {
      NumberConvert newNumber = new NumberConvert(5);
      string result = newNumber.OnesName();
      Assert.AreEqual("five", result);
    }      
    
    [TestMethod]
    public void TensName_RecieveLetterNameOfNumber_String()
    {
      NumberConvert newNumber = new NumberConvert(23);
      string result = newNumber.TensName();
      Assert.AreEqual("twenty three", result);
    }      
  }
}