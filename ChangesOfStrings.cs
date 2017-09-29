using System;
/*
 * Some functions which help chande random sequnces of strings
 */

namespace DEV_9_TwoStrings
{
  class WorkWithStrings
  {
    /*
     * This method find start and end indices sequences of strings
     * 
     * @param firstString 
     * @param secondString
     * @return array of changed strings
     */
    public String[] FindRandomIndexesAndСhangesRandomlyPartOfStrings (String firstString, String secondString)
    {
      int[] firstIndexesOfChanges = new int[2];
      firstIndexesOfChanges [0] = new Random().Next(0, firstString.Length - 1); 
      firstIndexesOfChanges [1] = new Random().Next(0, secondString.Length - 1);
      int[] lengthOfChanges = new int[2];
      lengthOfChanges[0] = new Random().Next(0, firstString.Length - firstIndexesOfChanges[0]);
      lengthOfChanges[1] = new Random().Next(0, secondString.Length - firstIndexesOfChanges[1]);
      String[] changedStrings = new String[2];
      changedStrings[0] = firstString;
      changedStrings[1] = secondString;
      return СhangesRandomlyPartOfString(firstIndexesOfChanges, lengthOfChanges, changedStrings);
    }

    /*
     * Replaces strings on strings with sequnces
     * 
     * @param firstIndexesOfChanges
     * @param lengthOfChanges
     * @param changedStrings
     * return array of changed String
     */
    public String[] СhangesRandomlyPartOfString(int[] firstIndexesOfChanges, int[] lengthOfChanges, String[] changedStrings)
    {
      String[] parstsOfFirstStrigAndSequence = DivideIntoParts(firstIndexesOfChanges[0], lengthOfChanges[0], changedStrings[0]);
      String[] parstsOfSecondStrigAndSequence = DivideIntoParts(firstIndexesOfChanges[1], lengthOfChanges[1], changedStrings[1]);
      changedStrings[0] = parstsOfFirstStrigAndSequence[0] + parstsOfSecondStrigAndSequence[1] + parstsOfFirstStrigAndSequence[2];
      changedStrings[1] = parstsOfSecondStrigAndSequence[0] + parstsOfFirstStrigAndSequence[1] + parstsOfSecondStrigAndSequence[2];
      return changedStrings;
    }

    /*
     * Split string on three part: first part - part before random sequnce, second - part of sequnce, third - remain of string
     * 
     * @param inputString
     * @param stratIndex
     * @param lengthOfSequnce
     * @return array which contain from three parts
     */
    public String[] DivideIntoParts(int startIndex, int lengthOfSequnce, String inputString)
    {
      String[] parts = new String[3];
      parts[0] = inputString.Substring(0, startIndex);
      parts[1] = inputString.Substring(startIndex, lengthOfSequnce);
      parts[2] = inputString.Substring(startIndex + lengthOfSequnce);
      return parts;
    }
  }
}
