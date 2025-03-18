public class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(string text, Reference reference)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split the text into words and create Word objects
        foreach (string word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public Reference Reference
    {
        get { return reference; }
        private set { reference = value; }
    }

    public string DisplayText()
    {
        // Display the scripture with hidden words replaced by underscores
        string displayedText = "";
        foreach (Word word in words)
        {
            displayedText += word.IsHidden ? "____ " : word.Text + " ";
        }
        return displayedText.Trim();
    }

    public void HideRandomWords()
    {
        // Randomly hide a few words that are not already hidden
        Random random = new Random();
        int wordsToHide = 3; // Number of words hidden per step

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = words.FindAll(w => !w.IsHidden);
            if (visibleWords.Count == 0)
                break;

            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.SetHidden(true);
        }
    }

    public bool AreAllWordsHidden()
    {
        // Check if all words are hidden
        return words.TrueForAll(w => w.IsHidden);
    }
}
