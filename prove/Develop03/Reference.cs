public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int? endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string Book
    {
        get { return book; }
        private set { book = value; }
    }

    public int Chapter
    {
        get { return chapter; }
        private set { chapter = value; }
    }

    public int StartVerse
    {
        get { return startVerse; }
        private set { startVerse = value; }
    }

    public int? EndVerse
    {
        get { return endVerse; }
        private set { endVerse = value; }
    }

    public string FullReference()
    {
        if (endVerse.HasValue)
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}";
        }
    }
}
