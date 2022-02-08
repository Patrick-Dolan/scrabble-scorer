using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer!");
      Console.WriteLine("===============================");
      Console.WriteLine("Type in a word to have it scored:");
      ScrabbleChecker scrabbleWord = new ScrabbleChecker(Console.ReadLine());
      Console.WriteLine("Your word would score: " + scrabbleWord.CalculateScore());
    }
  }
}