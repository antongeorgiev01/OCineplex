 namespace OCineplex.Data.Models
{
    using System;

    using OCineplex.Data.Common.Models;

    public class Reservation : BaseDeletableModel<int>
    {
        public DateTime ProjectionStartDate { get; set; }

        public string MovieName { get; set; }

        public string CinemaName { get; set; }

        public int HallNumber { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int ProjectionId { get; set; }

        public Projection Projection { get; set; }
    }
}
