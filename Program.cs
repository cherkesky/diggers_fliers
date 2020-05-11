using System;
using System.Collections.Generic;

/*
As an avid animal lover, you have started your very own collection of creatures in your home. You can use the code from the lesson as a starting point to have interfaces for walking and swimming animals, but you want to have several other kinds in your collection.

This is the list of animals you want to own and care for.

Parakeets
Earthworms
Terrapins
Timber Rattlesnake
Mice
Ants
Finches
Betta Fish
Copperhead snake
Gerbils
Each month, you clean out all of the habitats in a single day for efficiency. On that day, all animals need to be put into temporary containers. Each container will hold animals of similar similar, but different, types.

Animals that dig and live in the ground
Animals that move about on the ground
Animals that swim in water
Animals that fly above the ground
Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
*/

namespace diggers_fliers
{
  class Program
  {
    static void Main(string[] args)
    {
      Ants nelly = new Ants() { Name = "Nelly" };
      BettaFish fishy = new BettaFish() { Name = "Fishy" };
      CopperheadSnake slither = new CopperheadSnake() { Name = "Slither" };
      Earthworms slimy = new Earthworms() { Name = "Slimy" };
      Finches finchy = new Finches() { Name = "Finchy" };
      Gerbils gerby = new Gerbils() { Name = "Gerby" };
      Mice mickey = new Mice() { Name = "Mickey" };
      Parakeets para = new Parakeets() { Name = "Para" };
      Terrapins terra = new Terrapins() { Name = "Terra" };
      TimberRattleSnake timby = new TimberRattleSnake() { Name = "Timby" };

      Grounders.Container.Add(nelly);
      Swimmers.Container.Add(fishy);
      Grounders.Container.Add(slither);
      Grounders.Container.Add(slimy);
      Diggers.Container.Add(slimy);
      Grounders.Container.Add(finchy);
      Flyers.Container.Add(finchy);
      Grounders.Container.Add(gerby);
      Grounders.Container.Add(mickey);
      Flyers.Container.Add(para);
      Swimmers.Container.Add(terra);
      Grounders.Container.Add(terra);
      Grounders.Container.Add(timby);

      foreach (IGround item in Grounders.Container)
      {
        System.Console.WriteLine($"Grounder: {item}");
      }
      foreach (IFly item in Flyers.Container)
      {
        System.Console.WriteLine($"Flyers: {item}");
      }
      foreach (ISwim item in Swimmers.Container)
      {
        System.Console.WriteLine($"Swimmers: {item}");
      }
      foreach (IDig item in Diggers.Container)
      {
        System.Console.WriteLine($"Diggers: {item}");
      }


    }
  }
}
