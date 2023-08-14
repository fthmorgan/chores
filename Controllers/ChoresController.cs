using System.Data.Common;

namespace chores.Controllers;

[ApiController]

[Route("api/controller")]

public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetChores();
      return Ok(chores);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }

  [HttpGet("choreName")]
  public ActionResult<Chore> GeChoreByName(string choreName)
  {
    try
    {
      Chore chore = _choresService.GetChoreByName(choreName);
      return Ok(chore);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.CreateChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }
}