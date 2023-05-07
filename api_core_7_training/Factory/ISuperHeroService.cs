using api_core_7_training.Model;

namespace api_core_7_training.Factory
{
    public interface ISuperHeroService
    {
        Task<IList<SuperHeros>> GetAllSuperHeros();
        Task<SuperHeros> GetSuperHero(string name);
        Task<SuperHeros> GetSuperHero(Guid id);

        Task AddSuperHero(SuperHeros superHero);

        Task<bool> DeleteSuperHero(Guid id);

        Task<bool> UpdateSuperHero(SuperHeros superHero);
    }
}
