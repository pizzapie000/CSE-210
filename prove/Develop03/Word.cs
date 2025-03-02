public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text, bool isHidden = false)
    {
        this.text = text;
        this.isHidden = isHidden;
    }

    public string Text
    {
        get { return text; }
        private set { text = value; }
    }

    public bool IsHidden
    {
        get { return isHidden; }
        private set { isHidden = value; }
    }

    public void SetText(string text)
    {
        this.text = text;
    }

    public void SetHidden(bool hidden)
    {
        isHidden = hidden;
    }
}
