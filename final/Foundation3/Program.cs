class Program
{
    static void Main(string[] args)
    {
        // Minecraft lecture event
        Address address1 = new Address("123 Redstone Lane", "Blocksville", "MC", "Netherworld");
        Lecture minecraftLecture = new Lecture(
            "Diamond Mining 101", 
            "Learn efficient diamond mining and avoiding creepers.", 
            new DateTime(2025, 5, 10, 15, 0, 0), 
            address1, 
            "Steve the Miner", 
            64);

        // Stardew Valley event
        Address address2 = new Address("456 Pelican Plaza", "Stardew Valley", "SV", "Countryland");
        Reception stardewReception = new Reception(
            "Harvest Festival", 
            "season's harvest with dancing and starfruit wine.", 
            new DateTime(2025, 6, 15, 18, 0, 0), 
            address2, 
            "rsvp@stardewgala.com");

        Address address3 = new Address("789 Forest Path", "Gamewood", "GW", "Pixelverse");
        OutdoorEvent gamingOutdoorEvent = new OutdoorEvent(
            "Adventurer's Campfire", 
            "Gather around the campfire for stories, songs, and treasure maps!", 
            new DateTime(2025, 7, 20, 20, 0, 0), 
            address3, 
            "Clear skies with pixel-perfect weather");

        // Shows the  marketing messages
        Console.WriteLine(minecraftLecture.GetStandardDetails());
        Console.WriteLine(minecraftLecture.GetFullDetails());
        Console.WriteLine(minecraftLecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(stardewReception.GetStandardDetails());
        Console.WriteLine(stardewReception.GetFullDetails());
        Console.WriteLine(stardewReception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(gamingOutdoorEvent.GetStandardDetails());
        Console.WriteLine(gamingOutdoorEvent.GetFullDetails());
        Console.WriteLine(gamingOutdoorEvent.GetShortDescription());
    }
}
