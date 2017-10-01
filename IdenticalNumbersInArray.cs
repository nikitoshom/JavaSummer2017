using System;
using System.Collections;

/*
 * This class find identical value in each array and if count of identical values more than two write this value in new array.
 */

namespace DEV_10_Arraies_With_Simillar_Numbers
{
  class IdenticalNumbersInArray
  {
    const double epsilon = double.Epsilon;

    /*
     * This method find identical value in each array and if count of identical values more than two, write this value in new array.
     * param@ double[][] list
     * param@ return newArray
     */

    public ArrayList CreateNewArray(double[][] list)
    {
      ArrayList newArray = new ArrayList();
      for (int i = 0; i < list.Length - 1; i++)
      {
        for (int j = 0; j < list[i].Length; j++)
        {
          int count = 1;
          for (int k = i + 1; k < list.Length; k++)
          {
            for (int m = 0; m < list[k].Length; m++)
            {
              if (Math.Abs(list[i][j] - list[k][m]) < epsilon)
              {
                count++;
                break;
              }
            }
            if (count >= 2)
            {
              if (!newArray.Contains(list[i][j]))
              {
                newArray.Add(list[i][j]);
              }
              break;
            }
          }
        }
      }
      return newArray;
    }

    /*
     * This method output new array with the same values.
     * param@ newArray
     */

    public void OutputNewFloatArray(ArrayList newArray)
    {
      Console.WriteLine();
      for (int i = 0; i < newArray.Count; i++)
      {
        Console.Write(newArray[i] + " ");
      }
    }
  }
}
