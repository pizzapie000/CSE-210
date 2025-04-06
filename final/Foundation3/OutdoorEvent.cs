public class OutdoorEvent : Event
{
    private string weather; // Weather forecast for the event

    // Constructor
    public OutdoorEvent(string title, string description, DateTime date, Address address, string weather)
        : base(title, description, date, address)
    {
        this.weather = weather;
    }

    //All the details for the event
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Outdoor Event\nWeather Forecast: {weather}";
    }

    //short description
    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
