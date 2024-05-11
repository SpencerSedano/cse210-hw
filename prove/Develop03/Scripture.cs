using System.Text;

class Scripture
{
  private List<Word> _words;
  private StringBuilder displayText = new StringBuilder(); //Using StringBuilder we keep the same memory and instance

  public Scripture(string text)
  {
    // Split up the words in text and store each as a word object in the list _words
    _words = new List<Word>();
    
    string[] wordsStrings = text.Split();
    foreach (string wordString in wordsStrings)
    {
      Word word = new Word(wordString);
      _words.Add(word);
    }
  }

  public void HideRandomWords(int numbersToHide) 
  {
    Random random = new Random();

    // Create a list of indices of words that are not already hidden
    List<int> availableIndices = new List<int>();
    for (int i = 0; i < _words.Count; i++) // _words.Count means all the words
    {
        if (!_words[i].IsHidden())
        {
          availableIndices.Add(i);
        }
    }

    numbersToHide = Math.Min(numbersToHide, availableIndices.Count);

    for (int i = 0; i < numbersToHide; i++)
    {
        int randomIndex = random.Next(availableIndices.Count);
        int index = availableIndices[randomIndex];
        _words[index].Hide();
        availableIndices.RemoveAt(randomIndex);
    }

  }

  public string GetDisplayText()
  {
    displayText.Clear();

    foreach (Word word in _words)
    {
      displayText.Append(word.IsHidden() ? "_____" : word.GetDisplayText());
      displayText.Append(" ");
    }
    
    return displayText.ToString();
  }

  public bool IsCompletelyHidden()
  {
     foreach (Word word in _words)
    {
      if (!word.IsHidden())
        return false; // If any word is not hidden, return false
    }
      return true; // If ALL words are hidden
  }
}