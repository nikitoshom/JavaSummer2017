/*
 * This class of Custom, which has field of money which custom can spend on project and needed efficiency.
 */

namespace DEV_13_Custom
{
  class Custom
  {
    static int money;
    static int neededEfficiency;

    public int GetMoney()
    {
      return money;
    }

    public void SetMoney(int inputNumber)
    {
      money = inputNumber;
    }

    public int GetNeededEfficiency()
    {
      return neededEfficiency;
    }

    public void SetNeededEfficiency(int inputNumber)
    {
      neededEfficiency = inputNumber;
    }
  }
}
