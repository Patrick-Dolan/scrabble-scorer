namespace ScrabbleScorer.Models
{
  public class ScrabbleChecker
  {
    public string Word { get;set; }

    public ScrabbleChecker(string word)
    {
      Word = word;
    }
  }
}