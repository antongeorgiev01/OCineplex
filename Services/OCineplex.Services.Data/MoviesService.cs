namespace OCineplex.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using OCineplex.Data.Common.Repositories;
    using OCineplex.Data.Models;
    using OCineplex.Services.Mapping;

    public class MoviesService : IMoviesService
    {
        private readonly IDeletableEntityRepository<Movie> moviesRepository;

        public MoviesService(IDeletableEntityRepository<Movie> moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            IQueryable<Movie> query =
            this.moviesRepository.All().OrderBy(x => x.Title);


            return query.To<T>().ToList();
        }
    }
}
