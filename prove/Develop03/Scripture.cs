public class Scripture
{
    private string text;
    private Reference reference;

    public Scripture(string text, Reference reference)
    {
        this.text = text;
        this.reference = reference;
    }

    public string Text
    {
        get { return text; }
        private set { text = value; }
    }

    public Reference Reference
    {
        get { return reference; }
        private set { reference = value; }
    }

    public void SetText(string text)
    {
        this.text = text;
    }

    public void SetReference(Reference reference)
    {
        this.reference = reference;
    }
}
