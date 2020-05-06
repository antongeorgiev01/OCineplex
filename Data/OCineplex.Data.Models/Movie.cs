namespace OCineplex.Data.Models
{
    using System;
    using System.Collections.Generic;

    using OCineplex.Data.Common.Models;

    public class Movie : BaseDeletableModel<int>
    {
        public Movie()
        {
            this.Projections = new HashSet<Projection>();
        }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public TimeSpan Duration { get; set; }

        public double Rating { get; set; }

        public string Director { get; set; }

        public ICollection<Projection> Projections { get; set; }

        public string ImageUrl { get; set; }

    }
}