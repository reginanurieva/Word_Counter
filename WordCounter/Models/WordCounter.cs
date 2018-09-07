using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordModel
  {
    public string[] ParseStringToArrayStrings(string input1)
    {
      char[] delimiterChars = { ' ', ',', '.' };
      string[] inputWords = input1.Split(delimiterChars);
      return inputWords;
    }

    public int CountWordsMatches(string secondInput, string[] stringArray)
    {
      int counter = 0;
      foreach (var word in stringArray)
      {
        if(word.ToLower() == secondInput.ToLower())
        {
          counter++;
        }
      }
      return counter;
    }
  }


  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Please enter a sentence.");

      string enteredSentence = Console.ReadLine();

      Console.WriteLine("Please enter a word that you would like to count.");
      string enteredWord = Console.ReadLine();

      WordModel newWordModel = new WordModel();

      string[] stringArray = newWordModel.ParseStringToArrayStrings(enteredSentence);

      int result = newWordModel.CountWordsMatches(enteredWord,stringArray);
      Console.WriteLine("The word appears " + result + " times");


    }
  }
}
