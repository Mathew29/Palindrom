using System;
using System.Collections.Generic;
// using System.Linq;


namespace Sequence
{
  public class Program
  {
    public static void Main ()
    {

      Console.WriteLine("Enter a Word: ");
      string inputtedWord = Console.ReadLine().ToLower();
      char[] charArray = inputtedWord.ToCharArray();
      List<char> individualLetters = new List<char>();

      for (int i = charArray.Length - 1; i >= 0 ; i-- )
        {
          individualLetters.Add(charArray[i]);
        }

      string reversedInput = string.Join("", individualLetters);
      Console.WriteLine(reversedInput);

      if (reversedInput == inputtedWord)
      {
        Console.WriteLine("That's a friggin' Palindrome dude.");
      }
      else
      {
        Console.WriteLine("That ain't no friggin Palindrome dude.");
      }
    }
  }
}


// This is the way to do it with the .Reverse method
//
// Array.Reverse(charArray);
