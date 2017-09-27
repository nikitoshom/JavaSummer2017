using System;
/**
 * This class of two strings, for easier work with strings
 */

namespace DEV_9_TwoStrings
{
  class TwoStrings
  {
    private String firstString;
    private String secondString;

    public TwoStrings(String firstString, String secondString)
    {
      this.firstString = firstString;
      this.secondString = secondString;
    }

    public void setFirstString(String firstString)
    {
      this.firstString = firstString;
    }

    public void setSecondString(String secondString)
    {
      this.secondString = secondString;
    }

    public String getFirstString()
    {
      return this.firstString;
    }

    public String getSecondString()
    {
      return this.secondString;
    }
  }
}
