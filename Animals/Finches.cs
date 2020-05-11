namespace diggers_fliers
{
  public class Finches : IFly, IGround
  {
    public int WingSpan{get; set;}
    public void Running()
    {
      System.Console.WriteLine("Get set! Go! Running!");
    }
    public void Walking()
    {
      System.Console.WriteLine("Let's take the time and walk");
    }
    public void Flying()
    {
      System.Console.WriteLine("Look at me! I'm flying!!");
    }
    public void Landing()
    {
      System.Console.WriteLine("Watch out! I'm landing!");
    }
  }
}