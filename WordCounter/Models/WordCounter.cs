using System.Collections.Generic;

namespace WordCounter.Models
{
  public class CheckWord
  {
    public static List<CheckWord> inputWords = new List<CheckWord>() {};
    public string inputSentence;
    public string inputWord;
    // private char[] _delimiterChars = { ' ', ',', '.' };
    // private string[] inputWords = input1.Split(delimiterChars);
    // public string[] ParseStringToArrayStrings(string input1)
    public CheckWord(string inputSentence, string inputWord)
    {

      // char[] delimiterChars = { ' ', ',', '.' };
      // string[] inputWords = input1.Split(delimiterChars);
      // return delimiterChars;
      // Input = input1;
      // inputWords.Add(this);
    }

    // public string Input { get; set; }

    public int CountWordsMatches()
    {
      char[] delimiterChars = { ' ', ',', '.' };
      string[] inputList = inputWord.Split(delimiterChars);
      int counter = 0;
      foreach(string inputWord in inputList)
      {
        counter ++;
      }
      return counter;
      // int[] counter = new int[inputWords.Count];
      // int i = 0;
      // foreach (CheckWord word in inputWords)
      // {
      //   counter[i] = word.CheckWord();
      //   i++;
        // if(word)
        // {
        //   counter++;
        // }
      // }
      // return counter;
    }

    // public int CheckWords()
    // {
    //   int count = 0;
    //   int i = 0;
    //   while ((i = Sentence.IndexOf(Input, i)) != -1)
    // {
    //   i += Input.Length;
    //   count++;
    // }
    // return count;
    //
    // }
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
