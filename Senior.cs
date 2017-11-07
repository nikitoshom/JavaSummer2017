using System;

namespace DEV_13_Custom
{
  /*
   *this class of Senior, which shows fields of cost and efficiency of this worker. 
   */

  class Senior
  {
    private String qualification = "Senior";
    private int cost = 300;
    private int efficiency = 3300;

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
