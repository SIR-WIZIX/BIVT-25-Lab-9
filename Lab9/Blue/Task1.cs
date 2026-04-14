namespace Lab9.Blue;

public class Task1 : Blue
{
  private string[] _output;

  public string[] Output => _output.ToArray();

  public Task1(string input) : base(input){}

  public override void Review()
  {

  }

  public override string ToString()
  {
    string ans = "";
    foreach (string w in _output)
    {
      ans += w + ' ';
    }

    return ans.TrimEnd();
  }

}
