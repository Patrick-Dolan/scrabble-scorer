using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;

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
    [TestMethod]
    public void CalculateScore_ReturnScrabbleScore_Number()
    {
      ScrabbleChecker newScrabbleChecker = new ScrabbleChecker("Word");
      int score = 8;
      Assert.AreEqual(score, newScrabbleChecker.CalculateScore());
    }
  }
}