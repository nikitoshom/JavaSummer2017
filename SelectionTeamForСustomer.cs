using System;
using System.Linq;
using System.Text;

namespace DEV_13_Custom
{
  /*
   * This class has methods which help you find team for you conditions.
   */

  class SelectionTeamForСustomer
  {
    const String NOMONEY = "You haven't anought money";
    const String COST = "\nIt will be coast: $";
    const String NOFORFIXEFFICIENCY = "\nWe haven't workers for fixed productivity ";
    const String NOFIXEFFICIENCY = "It is impossible to select a team for a fixed productivity.";
    const String CLOSESTOPTION = "The closest option for you: ";
    const String EFFICIENCY = "\nReceived productivity: ";
    private const int AMOUNT = 4;
    private const int AMOUNTFORTHIRDTASK = 3;
    private const int COLUMN = 2;
    const String SPACE = " ";
    const String YOURTEAM = "Your team: ";
    private Team team = new Team
    {
      junior = new Junior(),
      middle = new Middle(),
      senior = new Senior(),
      lead = new Lead()
    };

    /*
     * in this method program create matrix with two column and has rows ascending in the first column. First column it is cost of one "string" of efficiency of each qualification.
     * Second column it is number of each qualification.
     * 
     * param@ double[,] advantageousPriceMatrix
     * return double[,] advantageousPriceMatrix
     */

    public double[,] CountAdvantageousPriceMatrix(double[,] advantageousPriceMatrix)
    {
      advantageousPriceMatrix[0, 0] = team.junior.CalculateLineCost();
      advantageousPriceMatrix[0, 1] = (int)Qualifications.Junior;
      advantageousPriceMatrix[1, 0] = team.middle.CalculateLineCost();
      advantageousPriceMatrix[1, 1] = (int)Qualifications.Middle;
      advantageousPriceMatrix[2, 0] = team.senior.CalculateLineCost();
      advantageousPriceMatrix[2, 1] = (int)Qualifications.Senior;
      advantageousPriceMatrix[3, 0] = team.lead.CalculateLineCost();
      advantageousPriceMatrix[3, 1] = (int)Qualifications.Lead;
      for (int count = 0; count < AMOUNT; count++)
      {
        for (int i = 0; i < (AMOUNT - 1); i++)
        {
          if (advantageousPriceMatrix[i, 0] > advantageousPriceMatrix[i + 1, 0])
          {
            for (int j = 0; j < COLUMN; j++)
            {
              double min = advantageousPriceMatrix[i, j];
              advantageousPriceMatrix[i, j] = advantageousPriceMatrix[i + 1, j];
              advantageousPriceMatrix[i + 1, j] = min;
            }
          }
        }
      }
      return advantageousPriceMatrix;
    }

    /*
     * This method build string with all information. (it is created for save memory)
     * param@ double[,] advantageousPriceMatrix
     * return@ myString
     */

    public StringBuilder BuildString(double[,] advantageousPriceMatrix)
    {
      StringBuilder myString = new StringBuilder();
      for (int i = AMOUNT - 1; i >= 0; i--)
      {
        switch (advantageousPriceMatrix[i, 1])
        {
          case 0:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.junior.GetQualification());
              myString.Append(SPACE);
            }
            break;
          case 1:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.middle.GetQualification());
              myString.Append(SPACE);
            }
            break;
          case 2:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.senior.GetQualification());
              myString.Append(SPACE);
            }
            break;
          case 3:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.lead.GetQualification());
              myString.Append(SPACE);
            }
            break;
        }
      }
      return myString;
    }

    /*
     * This method make team with maximum efficiency on all money which custom has.
     * 
     * param@ Custom custom
     */

    public void SelectionTeamForMoney(Custom custom)
    {
      double[,] advantageousPriceMatrix = new double[AMOUNT, COLUMN];
      advantageousPriceMatrix = CountAdvantageousPriceMatrix(advantageousPriceMatrix);
      int Sum = 0;
      int counter = 0;
      int efficiency = 0;
      int customMoney = custom.GetMoney();
      StringBuilder myString = new StringBuilder(YOURTEAM);
      for (int i = AMOUNT - 1; i >= 0; i--)
      {
        switch (advantageousPriceMatrix[i, 1])
        {
          case 0:
            Sum = 0;
            Sum = ((customMoney / team.junior.GetCost()) * team.junior.GetCost());
            advantageousPriceMatrix[i, 0] = customMoney / team.junior.GetCost();
            customMoney = customMoney - Sum;          
            counter = counter + ((int)advantageousPriceMatrix[i, 0]);
            efficiency = efficiency + (team.junior.GetEfficiency() * (int)advantageousPriceMatrix[i, 0]);
            break;
          case 1:
            Sum = 0;
            Sum = ((customMoney / team.middle.GetCost()) * team.middle.GetCost());
            advantageousPriceMatrix[i, 0] = customMoney / team.middle.GetCost();
            customMoney = customMoney - Sum;
            counter = counter + ((int)advantageousPriceMatrix[i, 0]);
            efficiency = efficiency + (team.middle.GetEfficiency() * (int)advantageousPriceMatrix[i, 0]);
            break;
          case 2:
            Sum = 0;
            Sum = ((customMoney / team.senior.GetCost()) * team.senior.GetCost());
            advantageousPriceMatrix[i, 0] = customMoney / team.senior.GetCost();
            customMoney = customMoney - Sum;
            counter = counter + ((int)advantageousPriceMatrix[i, 0]);
            efficiency = efficiency + (team.senior.GetEfficiency() * (int)advantageousPriceMatrix[i, 0]);
            break;
          case 3:
            Sum = 0;
            Sum = ((customMoney / team.lead.GetCost()) * team.lead.GetCost());
            advantageousPriceMatrix[i, 0] = customMoney / team.lead.GetCost();
            customMoney = customMoney - Sum;
            counter = counter + ((int)advantageousPriceMatrix[i, 0]);
            efficiency = efficiency + (team.lead.GetEfficiency() * (int)advantageousPriceMatrix[i, 0]);
            break;
        }
      }
      myString.Append(BuildString(advantageousPriceMatrix));
      myString.Append("\nBalance: $");
      myString.Append(customMoney);
      myString.Append(EFFICIENCY);
      myString.Append(efficiency);
      if (counter == 0)
        Console.WriteLine(NOMONEY);
      else
        Console.WriteLine(myString);
    }
    
    /*
     * This method make team on fix efficiency.
     * 
     * param@ Custom custom
     */

    public void SelectionTeamForEfficiency(Custom custom)
    {
      double[,] advantageousPriceMatrix = new double[AMOUNT, COLUMN];
      advantageousPriceMatrix = CountAdvantageousPriceMatrix(advantageousPriceMatrix);
      int Sum = 0;
      int cost = 0;
      int counter = 0;
      int neededEfficiency = custom.GetNeededEfficiency();
      StringBuilder myString = new StringBuilder(YOURTEAM);
      for (int i = AMOUNT - 1; i >= 0; i--)
      {
        switch (advantageousPriceMatrix[i, 1])
        {
          case 0:
            Sum = 0;
            Sum = ((neededEfficiency / team.junior.GetEfficiency()) * team.junior.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.junior.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.junior.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
          case 1:
            Sum = 0;
            Sum = ((neededEfficiency / team.middle.GetEfficiency()) * team.middle.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.middle.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.middle.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
          case 2:
            Sum = 0;
            Sum = ((neededEfficiency / team.senior.GetEfficiency()) * team.senior.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.senior.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.senior.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
          case 3:
            Sum = 0;
            Sum = ((neededEfficiency / team.lead.GetEfficiency()) * team.lead.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.lead.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.lead.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
        }
      }
      if (neededEfficiency > 0)
      {
        int[] costs = { team.junior.GetCost(), team.middle.GetCost(), team.senior.GetCost(), team.lead.GetCost() };
        int min = costs.Min();
        for (int i = 0; i < AMOUNT; i++)
        {
          if (costs[i] == min)
          {
            min = i;
            break;
          }
        }
        for (int i = 0; i < AMOUNT; i++)
        {
          if (advantageousPriceMatrix[i, 0] == min)
          {
            advantageousPriceMatrix[i, 0]++;
            break;
          }
        }
        switch (min)
        {
          case 0:
            cost = cost + team.junior.GetCost();
            break;
          case 1:
           cost = cost + team.middle.GetCost();
            break;
          case 2:
            cost = cost + team.senior.GetCost();
            break;
          case 3:
            cost = cost + team.lead.GetCost();
            break;
        }
      }
      myString.Append(BuildString(advantageousPriceMatrix));
      if (cost > custom.GetMoney())
      {
        Console.WriteLine(NOMONEY);
      }
      else
      {
        if (neededEfficiency == 0)
        {
          myString.Append(COST);
          myString.Append(cost);
          Console.WriteLine(myString);
        }
        else if (neededEfficiency > 0)
        {
          Console.WriteLine(NOFIXEFFICIENCY);
          Console.WriteLine(CLOSESTOPTION);
          Console.WriteLine(myString);
        }
      }
    }

    /*
     * This method make team on fix efficiency with minimum of workers.
     * 
     * param@ Custom custom
     */

    public void SelectionTeamWithoutJunior(Custom custom)
    {
      double[,] advantageousPriceMatrix = new double[AMOUNTFORTHIRDTASK, COLUMN];
      advantageousPriceMatrix[0, 0] = team.middle.GetEfficiency();
      advantageousPriceMatrix[0, 1] = (int)Qualifications.Middle - 1;
      advantageousPriceMatrix[1, 0] = team.senior.GetEfficiency();
      advantageousPriceMatrix[1, 1] = (int)Qualifications.Senior - 1;
      advantageousPriceMatrix[2, 0] = team.lead.GetEfficiency();
      advantageousPriceMatrix[2, 1] = (int)Qualifications.Lead - 1;
      for (int count = 0; count < AMOUNTFORTHIRDTASK; count++)
      {
        for (int i = 0; i < (AMOUNTFORTHIRDTASK - 1); i++)
        {
          if (advantageousPriceMatrix[i, 0] > advantageousPriceMatrix[i + 1, 0])
          {
            for (int j = 0; j < COLUMN; j++)
            {
              double min = advantageousPriceMatrix[i, j];
              advantageousPriceMatrix[i, j] = advantageousPriceMatrix[i + 1, j];
              advantageousPriceMatrix[i + 1, j] = min;
            }
          }
        }
      }
      int Sum = 0;
      int counter = 0;
      int cost = 0;
      int neededEfficiency = custom.GetNeededEfficiency();
      StringBuilder myString = new StringBuilder(YOURTEAM);
      for (int i = AMOUNTFORTHIRDTASK - 1; i >= 0; i--)
      {
        switch (advantageousPriceMatrix[i, 1])
        {
          case 0:
            Sum = 0;
            Sum = ((neededEfficiency / team.middle.GetEfficiency()) * team.middle.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.middle.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.middle.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
          case 1:
            Sum = 0;
            Sum = ((neededEfficiency / team.senior.GetEfficiency()) * team.senior.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.senior.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.senior.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
          case 2:
            Sum = 0;
            Sum = ((neededEfficiency / team.lead.GetEfficiency()) * team.lead.GetEfficiency());
            advantageousPriceMatrix[i, 0] = neededEfficiency / team.lead.GetEfficiency();
            neededEfficiency = neededEfficiency - Sum;
            cost = cost + (int)advantageousPriceMatrix[i, 0] * team.lead.GetCost();
            counter = +(int)advantageousPriceMatrix[i, 0];
            break;
        }
      }
      for (int i = AMOUNTFORTHIRDTASK - 1; i >= 0; i--)
      {
        switch (advantageousPriceMatrix[i, 1])
        {
          case 0:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.middle.GetQualification());
              myString.Append(SPACE);
            }
            break;
          case 1:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.senior.GetQualification());
              myString.Append(SPACE);
            }
            break;
          case 2:
            if (advantageousPriceMatrix[i, 0] != 0)
            {
              myString.Append(advantageousPriceMatrix[i, 0]);
              myString.Append(SPACE);
              myString.Append(team.lead.GetQualification());
              myString.Append(SPACE);
            }
            break;
        }
      }
      if (cost > custom.GetMoney())
      {
        Console.WriteLine(NOMONEY);
      }
      else
      {
        if (neededEfficiency == 0)
        {
          Console.WriteLine(myString);
        }
        else
        {
          Console.WriteLine(NOFIXEFFICIENCY);
        }
      }
    }    
  }
}
