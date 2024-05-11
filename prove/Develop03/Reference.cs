
class Reference 
{

  private string _book; 
  private int _chapter; 
  private int _verse; 
  private int _endVerse;
  private string _verseText;



  public Reference(string book, int chapter, int verse, string verseText)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _verseText = verseText;
  }

  public Reference(string book, int chapter, int verse, int endVerse, string verseText)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = endVerse;
    _verseText = verseText;
  }

  public string GetDisplayText()
  {
    if (_endVerse == 0)
    {
      return $"{_book} {_chapter}:{_verse}";
    }
    else
    {
      return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
  }

  public string GetCompleteVerse()
  {
    return $"{_verseText}";
  }
}