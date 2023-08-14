namespace chores.Repositories;

public class ChoresRepository
{
  private List<Chore> dbChores;

  public ChoresRepository()
  {
    dbChores = new List<Chore>();
    dbChores.Add(new Chore("Dishes", 30, true, true));
    dbChores.Add(new Chore("Vacuuming", 10, false, true));
    dbChores.Add(new Chore("Mopping", 30, false, false));
  }

  internal List<Chore> GetChores()
  {
    return dbChores;
  }
  internal Chore GetChoreByName(string choreName)
  {
    Chore foundChore = dbChores.Find(chore => chore.Name == choreName);
    return foundChore;
  }

  internal Chore CreateChores(Chore choreData)
  {
    dbChores.Add(choreData);
    return choreData;
  }
}