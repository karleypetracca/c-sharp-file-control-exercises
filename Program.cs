// // Uncomment exercises below to run! // //

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FileControlExercises
{
  class Program
  {
    // /*
    // Write a program that reads a text file and displays the number of words.
    // */
    // static void Main(string[] args)
    // {
    //   var text = File.ReadAllText(@".\text.txt");
    //   Console.WriteLine(text);
    // }


    /*
    Write a program that reads a text file and displays the longest word in the file.
    */
    static void Main(string[] args)
    {
      var text = File.ReadAllText(@".\text.txt");
      Console.WriteLine(longestWord(text));
    }

    public static string longestWord(string text)
    {
      var longest = "";
      foreach (var word in text.Split(" "))
      {
        var trimmedWord = Regex.Replace(word, "[^a-zA-Z]", String.Empty);
        if (trimmedWord.Length > longest.Length)
        {
          longest = trimmedWord;
        }
      }
      return longest;
    }
  }
}
