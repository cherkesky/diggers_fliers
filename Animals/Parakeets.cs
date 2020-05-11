namespace diggers_fliers
{
  public class Parakeets : IFly
  {
    public int WingSpan { get; set; }

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