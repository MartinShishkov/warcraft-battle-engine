namespace Engine.Models.Util
{
  public static class Percentage
  {
    public static int From(int percent, int absoluteValue)
    {
      var multiplier = (double)percent / 100;
      var amount = (int)Math.Ceiling(absoluteValue * multiplier);
      return amount;
    }

    public static int Half(int absoluteValue)
    {
      return From(50, absoluteValue);
    }
  }
}
