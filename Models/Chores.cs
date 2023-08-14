namespace chores.Models;

public class Chore
{
  public string Name { get; set; }
  public int Minutes { get; set; }
  public bool IsHard { get; set; }
  public bool DoneDaily { get; set; }

  public Chore(string name, int minutes, bool isHard, bool doneDaily)
  {
Name = name;
Minutes = minutes;
IsHard = isHard;
DoneDaily = doneDaily;

  }
}