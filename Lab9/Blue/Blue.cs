namespace Lab9.Blue
{
  abstract class Blue
  {
    private string _input;

    public string Input => _input;

    protected Blue(string input)
    {
      _input = input;
    }

    abstract void Review();

    virtual void ChangeText(string text)
    {
      _input = text;
      Review();
    }
  }
}
