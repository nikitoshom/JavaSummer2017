using System;

namespace DEV_13_Custom
{
  /*
   *this class of Lead, which shows fields of cost and efficiency of this worker. 
   */

  class Lead
  {
    private String qualification = "Lead";
    private int cost = 500;
    private int efficiency = 8000;

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
