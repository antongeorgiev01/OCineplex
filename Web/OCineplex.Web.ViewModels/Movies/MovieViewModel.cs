namespace OCineplex.Web.ViewModels.Movies
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using OCineplex.Data.Models;
    using OCineplex.Services.Mapping;
    using OCineplex.Web.ViewModels.Projections;

    public class MovieViewModel : IMapFrom<Movie>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public TimeSpan Duration { get; set; }

        public double Rating { get; set; }

        public string Director { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string TrailerUrl { get; set; }

        public IEnumerable<ProjectionInViewModel> Projections { get; set; }
    }
}
