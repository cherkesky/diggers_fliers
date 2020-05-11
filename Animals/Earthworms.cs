namespace diggers_fliers
{
  public class Earthworms : IGround, IDig
  {
    public void Running()
    {
      System.Console.WriteLine("Get set! Go! Running!");
    }
    public void Walking()
    {
      System.Console.WriteLine("Let's take the time and walk");
    }
    public void Digging(){
      System.Console.WriteLine("I'm digging! Almost there!");
    }
  }
}