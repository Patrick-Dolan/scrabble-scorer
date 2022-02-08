using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleCheckerTests
  {
    [TestMethod]
    public void ScrabbleCheckerConstructor_CreateScrabbleCheckerObject_ScrabbleChecker()
    {
      ScrabbleChecker newScrabbleChecker = new ScrabbleChecker("Word");
      Assert.AreEqual(typeof(ScrabbleChecker), newScrabbleChecker.GetType());
    }
    [TestMethod]
    public void ScrabbleChecker_AssignWordToScrabbleChecker_ScrabbleChecker()
    {
      ScrabbleChecker newScrabbleChecker = new ScrabbleChecker("Word");
      string result = newScrabbleChecker.Word;
      Assert.AreEqual("Word", result);
    }
  }
}
// Example Test Method Structure
//_________________________
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }