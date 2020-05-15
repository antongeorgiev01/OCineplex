namespace OCineplex.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using OCineplex.Data.Common.Repositories;
    using OCineplex.Data.Models;

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
    }
}
