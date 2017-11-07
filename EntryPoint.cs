using System;

namespace DEV_13_Custom
{
  /*
   * This program find you team for your project. Your input amount of money which you have and efficiency which you needed.
   * AFter your the menu item you want to perform. It is Maximum productivity within the amount or The minimum cost for a fixed productivity or Minimum number of employees is higher than Junior for fixed productivity.
   * finally program say that can you find for your project team or not
   */

  class EntryPoint
  {
    const String MENU = "Please select the menu item you want to perform:\n 1) Maximum productivity within the amount \n 2) The minimum cost for a fixed productivity \n 3) Minimum number of employees is higher than Junior for fixed productivity ";
    const String REPEAT = "Do you want change your data about money or efficiency: ";
    const String CONTINUE = "Press Enter to REPEAT";

    static void Main(string[] args)
    {
      do
      {
        try
        {
          Custom custom = new Custom();
          Inputer inputer = new Inputer();
          inputer.InputCustomMoney(custom);
          inputer.InputCustomEfficiency(custom);
          SelectionTeamForСustomer selection = new SelectionTeamForСustomer();
          do
          {
            Console.WriteLine(MENU);
            int choice = inputer.SelectItemOfMenu();
            switch (choice)
            {
              case 1:
                selection.SelectionTeamForMoney(custom);
                break;
              case 2:
                selection.SelectionTeamForEfficiency(custom);
                break;
              case 3:
                selection.SelectionTeamWithoutJunior(custom);
                break;
            }
            Console.Write(REPEAT);
          }
          while (!inputer.SelectRepeatOrNot());
          Console.WriteLine(CONTINUE);
        }
        catch (Exception exc)
        {
          Console.WriteLine(exc.Message);
        }
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }
}
