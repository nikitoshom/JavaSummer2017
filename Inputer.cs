using System;

/*
 * This class has all methods which help us input data.
 */

namespace DEV_13_Custom
{
  class Inputer
  {
    const String INPUTCOAST = "Please, Enter the amount of money which you have: $";
    const String INPUTEFFICIENCY = "Please, Enter the efficiency which you need for project: ";
    const String YES = "Yes";
    const String YESSMALLLETTERS = "yes";

    /*
     * This method input data about money which custom can spend.
     * @param custom
     * @return custom
     */

    public Custom InputCustomMoney(Custom custom)
    {
      Console.Write(INPUTCOAST);
      custom.SetMoney(Convert.ToInt32(Console.ReadLine()));
      return custom;
    }

    /*
     * This method input data about efficiency which custom needs.
     * @param custom
     * @return custom
     */

    public Custom InputCustomEfficiency(Custom custom)
    {
      Console.Write(INPUTEFFICIENCY);
      custom.SetNeededEfficiency(Convert.ToInt32(Console.ReadLine()));
      return custom;
    }

    /*
     * This method input data about item of menu.
     */

    public int SelectItemOfMenu()
    {
      return Convert.ToInt32(Console.ReadLine());
    }

    /*
     * This method input word "yes" || "Yes" if you want repeat input  or another different letter of sequence of letters to continue work with data which we have.
     */

    public Boolean SelectRepeatOrNot()
    {
      String selection = Convert.ToString(Console.ReadLine());
      return YES == selection || YESSMALLLETTERS == selection;
    }
  }
}
