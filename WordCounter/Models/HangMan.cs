// using System.Collections.Generic;
// using System;
//
// namespace HangMan.Models
// {
//   public class HangManGame
//   {
//     public static string[] potentialWords = {"apple", "orange", "peach"};
//     public static string pickRandomWord()
//     {
//       return potentialWords[new Random().Next(0, 2)];
//     }
//
//     private string _solution = "";
//     private int _spaces = 0;
//
//     public HangManGame()
//     {
//        _solution = HangManGame.pickRandomWord();
//        _spaces = _solution.Length;
//     }
//
//     public string GetSolution()
//     {
//       return _solution;
//     }
//
//     public int GetSpaces()
//     {
//       return _spaces;
//     }


// 
//   }
// }

//Know how many letters are in the word we're guessing
//Know what word we're trying to guess
//Determine if guessed letter is included in word
//Keep track of the number of incorrect guesses
//Keep track of what letters have already been guessed
//Should be able to end game after a certain number of wrong guesses
//Should be able to start new gamej
//Randomly select word upon being birthed
