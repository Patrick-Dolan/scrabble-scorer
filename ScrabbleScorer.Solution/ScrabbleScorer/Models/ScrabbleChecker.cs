using System.Collections.Generic;
namespace ScrabbleScorer.Models
{
  public class ScrabbleChecker
  {
    public string Word { get;set; }
    public static Dictionary<char, int> ScoreDictionary = new Dictionary<char, int>() {
      {'A', 1},
      {'E', 1},
      {'I', 1},
      {'O', 1},
      {'U', 1},
      {'L', 1},
      {'N', 1},
      {'R', 1},
      {'S', 1},
      {'T', 1},
      {'D', 2},
      {'G', 2},
      {'B', 3},
      {'C', 3},
      {'M', 3},
      {'P', 3},
      {'F', 4},
      {'H', 4},
      {'V', 4},
      {'W', 4},
      {'Y', 4},
      {'K', 5},
      {'J', 8},
      {'X', 8},
      {'Q', 10},
      {'Z', 10}
    };
    public ScrabbleChecker(string word)
    {
      Word = word;
    }

    public int CalculateScore()
    {
      string temp = Word.ToUpper();
      int score = 0;
      foreach (char c in temp)
      {
        score += ScoreDictionary[c];
      }
      return score;
    }
  }
}