namespace OCineplex.Data.Models
{
    using System.Collections.Generic;

    using OCineplex.Data.Common.Models;

    public class Hall : BaseDeletableModel<int>
    {
        public Hall()
        {
            this.Projections = new HashSet<Projection>();
            this.Seats = new HashSet<Seat>();
        }

        public string Name { get; set; }

        public bool Is2D { get; set; }

        public bool Is3D { get; set; }

        public ICollection<Projection> Projections { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}