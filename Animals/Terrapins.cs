namespace diggers_fliers
{
  public class Terrapins : IGround, ISwim
  {
    public void Swimming()
    {
      System.Console.WriteLine("Swimming...");
    }
    public void Diving()
    {
      System.Console.WriteLine("Diving! Bloop Bloop!");
    }
    public void Running()
    {
      System.Console.WriteLine("Get set! Go! Running!");
    }
    public void Walking()
    {
      System.Console.WriteLine("Let's take the time and walk");
    }
  }
}