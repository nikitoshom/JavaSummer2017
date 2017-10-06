using System;

namespace DEV_11_Translit
{
  /*
   * This program converting string, which was written in Cyrillica, into string was written in Latin and vice versa.
   */
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        StringConvertor stringConvertor = new StringConvertor();
        string str = Console.ReadLine();
        str = stringConvertor.Translaite(str);
        Console.WriteLine(str);
        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
