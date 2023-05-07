using api_core_7_training.Data;
using api_core_7_training.Model;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace api_core_7_training.Factory
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _dataContext;

        public SuperHeroService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task AddSuperHero(SuperHeros superHero)
        {
            await _dataContext.SuperHeros.AddAsync(superHero);
        }

        public async Task<bool> DeleteSuperHero(Guid id)
        {
            _dataContext.SuperHeros.Remove(await GetSuperHero(id));
            return true;// TODO
        }
        public async Task<IList<SuperHeros>> GetAllSuperHeros()
        {
            var superHeros = await _dataContext.SuperHeros.ToListAsync();
            return superHeros;
        }

        public async Task<SuperHeros> GetSuperHero(string name)
        {
            return await _dataContext.SuperHeros.Where(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task<SuperHeros> GetSuperHero(Guid id)
        {
            return await _dataContext.SuperHeros.Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateSuperHero(SuperHeros superHero)
        {
            _dataContext.SuperHeros.Update(superHero);
            return true;//todo
        }
    }
}
