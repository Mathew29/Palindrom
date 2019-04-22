using System;
using System.Collections.Generic;
using System.Linq;


namespace Sequence
{
  public class Program
  {
    public static void Main ()
    {



      Console.WriteLine("Enter a Word: ");
      string inputtedWord = Console.ReadLine().ToLower();
      char[] charArray = inputtedWord.ToCharArray();

      Array.Reverse(charArray);

      string reversedInput = string.Join("", charArray);
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
