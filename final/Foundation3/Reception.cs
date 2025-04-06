public class Reception : Event
{
    private string rsvpEmail; // RSVP email address

    // Constructor to initialize reception-specific attributes
    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
        : base(title, description, date, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    /// <summary>
    /// Provides full details, including RSVP email.
    /// </summary>
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {rsvpEmail}";
    }

    /// <summary>
    /// Provides a brief description of the reception.
    /// </summary>
    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
