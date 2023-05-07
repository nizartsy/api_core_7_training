using api_core_7_training.Factory;
using api_core_7_training.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_core_7_training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<SuperHeros>>> GetAllSuperHeros()
        {
            return Ok(await _superHeroService.GetAllSuperHeros());
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<SuperHeros>> GetSuperHero(string name)
        {
            var hero = await _superHeroService.GetSuperHero(name);
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<IList<SuperHeros>>> AddSuperHeo(SuperHeros superHeros)
        {
            await _superHeroService.AddSuperHero(superHeros).ConfigureAwait(false);
            var list = await _superHeroService.GetAllSuperHeros();
            return Ok(list);
        }
    }
}
