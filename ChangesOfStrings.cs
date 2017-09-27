using System;
/*
 * Some functions which help chande random sequnces of strings
 */

namespace DEV_9_TwoStrings
{
  class ChangesOfStrings
  {
    /*
     * This method gives start and end indices sequences of strings
     * 
     * @param twoStrings object with tow strings
     */
    public void randomChangesBetweenString(TwoStrings twoStrings)
    {
      int firstIndexOfChanges = new Random().Next(0, twoStrings.getFirstString().Length - 1);
      int firstLengthOfChanges = new Random().Next(0, twoStrings.getFirstString().Length - firstIndexOfChanges);
      int secondIndexOfChanges = new Random().Next(0, twoStrings.getSecondString().Length - 1);
      int secondLengthOfChanges = new Random().Next(0, twoStrings.getSecondString().Length - secondIndexOfChanges);
      Changes(firstIndexOfChanges, firstLengthOfChanges, secondIndexOfChanges, secondLengthOfChanges, twoStrings);
    }

    /*
     * Replaces strings on strings with sequnces. Symbols "|" show where sequnce wich changed in each string.
     * 
     * @param firstIndexOfChanges
     * @param firstLengthOfChanges
     * @param secondIndexOfChanges
     * @param secondLengthOfChanges
     * @param twoStrings
     */
    public void Changes(int firstIndexOfChanges, int firstLengthOfChanges, int secondIndexOfChanges, int secondLengthOfChanges, TwoStrings twoStrings)
    {
      String[] parstsOfFirstStrigAndSequence = DivideIntoParts(firstIndexOfChanges, firstLengthOfChanges, twoStrings.getFirstString());
      String[] parstsOfSecondStrigAndSequence = DivideIntoParts(secondIndexOfChanges, secondLengthOfChanges, twoStrings.getSecondString());
      twoStrings.setFirstString(parstsOfFirstStrigAndSequence[0] +"|"+ parstsOfSecondStrigAndSequence[1]+"|"+ parstsOfFirstStrigAndSequence[2]);
      twoStrings.setSecondString(parstsOfSecondStrigAndSequence[0] + "|" + parstsOfFirstStrigAndSequence[1] + "|" + parstsOfSecondStrigAndSequence[2]);
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
