namespace diggers_fliers
{

  public class BettaFish : ISwim
  {
    public string Name;

    public void Swimming()
    {
      System.Console.WriteLine("Swimming...");
    }
    public void Diving()
    {
      System.Console.WriteLine("Diving! Bloop Bloop!");
    }
  }
}