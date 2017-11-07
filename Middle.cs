using System;

namespace DEV_13_Custom
{
  /*
   *this class of Middle, which shows fields of cost and efficiency of this worker. 
   */

  class Middle
  {
    private String qualification = "Middle";
    private int cost = 200;
    private int efficiency = 2100;

    public String GetQualification()
    {
      return this.qualification;
    }

    public int GetCost()
    {
      return this.cost;
    }

    public int GetEfficiency()
    {
      return this.efficiency;
    }

    public double CalculateLineCost()
    {
      double calculateLineCost = (double)this.efficiency / this.cost;
      return calculateLineCost;
    }
  }
}
