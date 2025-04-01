public class Word
{
    // Properties
    public string Text { get; }
    public bool IsHidden { get; private set; }

    // Constructor
    public Word(string text, bool isHidden = false)
    {
        Text = text;
        IsHidden = isHidden;
    }

    public void SetHidden(bool hidden)
    {
        IsHidden = hidden;
    }
}

