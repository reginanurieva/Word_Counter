using System;
using System.Collections.Generic;
// using System.Linq;

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
        if(word == secondInput)
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
    // Console.ReadLine();
    string enteredSentence = Console.ReadLine();
    // Item newItem = new Item(enteredSentence);

    Console.WriteLine("Please enter a word that you would like to count.");
    string enteredWord = Console.ReadLine();

    WordModel newWordModel = new WordModel();

    string[] stringArray = newWordModel.ParseStringToArrayStrings(enteredSentence);

    int result = newWordModel.CountWordsMatches(enteredWord,stringArray);
    Console.WriteLine("The word appers " + result + " times");
    // Main();

    // // x += counter[index++];
    //
    // if (CountWordsMatches(word == secondInput))
    //   {
    //     // int expectedMatches = counter;
    //     Console.WriteLine("This word appear in your sentence" + counter + "times");
    //     // return true;
    //   }
    //   else {
    //     Console.WriteLine("Something went wrong!");
    //     // return false;
    //   }


  }
}
}
