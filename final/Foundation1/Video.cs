public class Video
{
  public string _title;
  public string _author;
  public int _length;
  public List<Comment> _comments = new List<Comment>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  // Add a comment to the list
  public void AddComment(string nameComment, string textComment)
  {
    _comments.Add(new Comment {_name = nameComment, _text = textComment});
  }


  // Display the Video and all of the comments
  public string DisplayVideoInfo()
  {
    // I had errors here, I cannot Console.WriteLine everything and expect to 
    // use this value in another part of my program, that is why there is
    // the return value
    string myVariable = $"{_title} by {_author} ({_length} seconds)";
    return myVariable;
/*     foreach (Comment comment in _comments)
    {
      Console.WriteLine($"{comment._name}: {comment._text}");
    } */
  }

  /*public string DisplayComments()
  {
    foreach (Comment comment in _comments)
    {
      return $"{comment._name}: {comment._text}";
    }
  }*/

  // Get the number of comments
}