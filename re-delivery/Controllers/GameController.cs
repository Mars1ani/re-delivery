using Microsoft.AspNetCore.Mvc;
using re_delivery.Service;
using System.Runtime.InteropServices;

namespace re_delivery.Controllers
{ 
[ApiController]
[Route("api-games")]
public class GameController : ControllerBase
{
    private readonly GameService _gameService;

    public GameController(GameService gameService)
    {
            _gameService = gameService
    }
        [HttpGet]
        public ActionResult GetAll()
        {
            var games = _gameService.GetAll();
            return Ok(games);
        }
        [HttpGet("{id}")]
    public ActionResult GetAll(long id)
    {
          var games = _gameService.GetById(id);
         return Ok(games);
    }
        [HttpPost]
        public ActionResult Create(Game game)
        {

            Long gameId = _gameService.Create(game);

            return Created($"api/games/{gameId}", game);
        }
        [HttpPut("{id}")]

    public ActionResult Update(Game game)
        {

        }

        [HttpDelete("{id}")]

        public ActionResult Delete(long id)
        {

            bool result = _gameService.Delete(id);

            if (result) return NoContent();

            return NotFound();
        }
}

