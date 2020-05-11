namespace diggers_fliers
{
  public interface IFly
  {
    int WingSpan { get; set; }
    void Flying();
    void Landing();
  }
}