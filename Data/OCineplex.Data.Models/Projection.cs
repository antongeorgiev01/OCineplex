namespace OCineplex.Data.Models
{
    using System;
    using System.Collections.Generic;

    using OCineplex.Data.Common.Models;

    public class Projection : BaseDeletableModel<int>
    {
        public Projection()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int HallId { get; set; }

        public Hall Hall { get; set; }

        public DateTime DateTime { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}