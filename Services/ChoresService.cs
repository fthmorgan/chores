namespace chores.Services;

public class ChoresService
{
  private readonly ChoresRepository _choreRepository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _choreRepository = choresRepository;
  }
  internal List<Chore> GetChores()
  {
    List<Chore> chores = _choreRepository.GetChores();
    return chores;
  }

  internal Chore GetChoreByName(string choreName)
  {
    Chore chore = _choreRepository.GetChoreByName(choreName);

    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _choreRepository.CreateChores(choreData);
    return chore;
  }
}