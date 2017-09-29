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
      const String firstString = "Hello, how are you?";
      const String secondString = "My name is Nikita";
      Console.WriteLine(firstString);
      Console.WriteLine(secondString);
      WorkWithStrings workWithStrings = new WorkWithStrings();
      String[] changedStrings = workWithStrings.FindRandomIndexesAndСhangesRandomlyPartOfStrings(firstString,secondString);
      Console.WriteLine(changedStrings[0]);
      Console.WriteLine(changedStrings[1]);
      Console.ReadKey();
    }
  }
}

