using System;

/**
 * This program takes two string and change random sequnce of one string with random sequnce of another string
 */

namespace DEV_9_TwoStrings
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      String firstString = "Hellow, how are you?";
      String secondString = "My name is Nikita";
      TwoStrings twoStrings = new TwoStrings(firstString, secondString);
      Console.WriteLine(twoStrings.getFirstString());
      Console.WriteLine(twoStrings.getSecondString());
      ChangesOfStrings changesOfStrings = new ChangesOfStrings();
      changesOfStrings.randomChangesBetweenString(twoStrings);
      Console.WriteLine(twoStrings.getFirstString());
      Console.WriteLine(twoStrings.getSecondString());
      Console.ReadKey();
    }
  }
}
