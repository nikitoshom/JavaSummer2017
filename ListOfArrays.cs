using System;

/*
 *  This class create list of arrays with random number of arrays, randow size of each array and random numbers in.
 */

namespace DEV_10_Arraies_With_Simillar_Numbers
{
  class ListOfArrays
  {
    const int minCount = 1;
    const int maxCount = 20;
    const int minLength = 5;
    const int maxLength = 20;

    /*
     * This method create list of arrays with random number of arrays, randow size of each array and random numbers in.
     * return@ double[][] list 
     */
    
    public double [][] CreateListOfArrays() {
      double[][] list;
      Random random = new Random();
      list = new double[random.Next(minCount, maxCount)][];
      for (int i = 0; i < list.Length; i++)
      {
        list[i] = new double[random.Next(minLength, maxLength)];
        for (int j = 0; j < list[i].Length; j++)
        {
          list[i][j] = Math.Round(random.NextDouble() * 10, 3, MidpointRounding.AwayFromZero);
        }
      }
      return list;
    }

    /*
     * This method output list of arrays.
     * param@ double[][] list
     */

    public void OutputListOfArrays(double[][] list)
    {
      for (int i = 0; i < list.Length; i++)
      {
        for (int j = 0; j < list[i].Length; j++)
        {
          Console.Write(list[i][j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
