namespace OCineplex.Data.Models
{
    using System.Collections.Generic;

    using OCineplex.Data.Common.Models;

    public class Hall : BaseDeletableModel<int>
    {
        public Hall()
        {
            this.Projections = new HashSet<Projection>();
        }

        public int Number { get; set; }

        public short SeatsPerRow { get; set; }

        public short Rows { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public ICollection<Projection> Projections { get; set; }
}
}
