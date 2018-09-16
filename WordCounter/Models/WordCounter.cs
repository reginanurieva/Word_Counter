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

    public static int CountWordsInText(string countWord,string[] sentence)
    {
        int counter = 0;
        foreach (var word in sentence)
        {
            if (string.Equals(word, countWord, System.StringComparison.CurrentCultureIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
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
}
