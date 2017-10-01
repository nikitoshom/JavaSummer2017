using System;
using System.Collections;

/*
 *This progaram create list of arrays with random number of arrays, randow size of each array and random numbers in. 
 * After creating program find identical value in each array and if count of simmilar values more than two write thic value in new array.
 */

namespace DEV_10_Arraies_With_Simillar_Numbers
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      ListOfArrays listOfArrays = new ListOfArrays();
      double[][] list = listOfArrays.CreateListOfArrays();
      listOfArrays.OutputListOfArrays(list);
      IdenticalNumbersInArray identicalNumbersInArray = new IdenticalNumbersInArray();
      ArrayList newArray = identicalNumbersInArray.CreateNewArray(list);
      identicalNumbersInArray.OutputNewFloatArray(newArray);
      Console.ReadKey();
    }
  }
}
