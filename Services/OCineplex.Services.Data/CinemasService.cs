namespace OCineplex.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using OCineplex.Data.Common.Repositories;
    using OCineplex.Data.Models;
    using OCineplex.Services.Mapping;

    public class CinemasService : ICinemasService
    {
        private readonly IDeletableEntityRepository<Cinema> cinemasRepository;

        public CinemasService(IDeletableEntityRepository<Cinema> cinemasRepository)
        {
            this.cinemasRepository = cinemasRepository;
        }

        public async Task<int> CreateAsync(string name, string address, string imageUrl)
        {
            var cinema = new Cinema
            {
                Name = name,
                Address = address,
                ImageUrl = imageUrl,
            };

            await this.cinemasRepository.AddAsync(cinema);
            await this.cinemasRepository.SaveChangesAsync();

            return cinema.Id;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Cinema> query =
                this.cinemasRepository.All().OrderBy(x => x.Name);

            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }
    }
}
