public class Lecture : Event
{
    private string speaker;
    private int capacity; // max capacity

    // Constructor
    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity)
        : base(title, description, date, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    //Gives all the details and for the speaker and capacity
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    //Short description of the event
    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
