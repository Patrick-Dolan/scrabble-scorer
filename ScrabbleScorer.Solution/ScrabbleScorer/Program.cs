using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer!");
      RunChecker(); //We are recursive legends
    }
    public static void RunChecker()
    {
      Console.WriteLine("===============================");
      Console.WriteLine("Type in a word to have it scored:");
      ScrabbleChecker scrabbleWord = new ScrabbleChecker(Console.ReadLine());
      Console.WriteLine(scrabbleWord.Word + " would score: " + scrabbleWord.CalculateScore());
      
      Console.WriteLine("Would you like to score another word?");
      string checkMoreWords = Console.ReadLine();
      if (checkMoreWords == "Y" || checkMoreWords == "y")
      {
        RunChecker();
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
  }
}