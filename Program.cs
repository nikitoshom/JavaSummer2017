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
      ConvertString dictionary = new ConvertString();     
      string str = Console.ReadLine();
      str = dictionary.Transliter(str);
      Console.WriteLine(str);
      Console.ReadKey();      
    }
  }
}
