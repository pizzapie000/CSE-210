public abstract class Event
{
    protected string title; 
    protected string description; 
    protected DateTime date; 
    protected Address address; 

    // Constructor
    protected Event(string title, string description, DateTime date, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {date.ToShortTimeString()}\nLocation:\n{address.FullAddress()}";
    }

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}
