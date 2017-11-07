using System;

namespace DEV_13_Custom
{
  /*
   *this class of Junior, which shows fields of cost and efficiency of this worker. 
   */

  class Junior
  {
    private String qualification = "Junior";
    private int cost = 100;
    private int efficiency = 1000;

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
