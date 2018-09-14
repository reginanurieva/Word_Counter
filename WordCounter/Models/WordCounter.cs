using System.Collections.Generic;

namespace WordCounter.Models
{
  public class CheckWord
  {
    public static string Sentence;
    public static List<CheckWord> inputWords = new List<CheckWord>() {};
    // private char[] _delimiterChars = { ' ', ',', '.' };
    // private string[] inputWords = input1.Split(delimiterChars);
    // public string[] ParseStringToArrayStrings(string input1)
    public CheckWord(string input1)
    {
      char[] delimiterChars = { ' ', ',', '.' };
      string[] inputWords = input1.Split(delimiterChars);
      // return delimiterChars;
      inputWords.Add(this);
    }

    public string input1 { get; set; }

    public int CountWordsMatches()
    {
      int counter = 0;
      foreach (CheckWord word in inputWords)
      {
        if(word.ToLower())
        {
          counter++;
        }
      }
      return counter;
    }
  }


  // public class Program
  // {
  //   static void Main()
  //   {
  //     Console.WriteLine("Please enter a sentence.");
  //
  //     string enteredSentence = Console.ReadLine();
  //
  //     Console.WriteLine("Please enter a word that you would like to count.");
  //     string enteredWord = Console.ReadLine();
  //
  //     WordModel newWordModel = new WordModel();
  //
  //     string[] stringArray = newWordModel.ParseStringToArrayStrings(enteredSentence);
  //
  //     int result = newWordModel.CountWordsMatches(enteredWord,stringArray);
  //     Console.WriteLine("The word appears " + result + " times");
  //
  //
  //   }
  // }
}
