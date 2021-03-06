﻿namespace OCineplex.Data.Models
{
    using System;

    using OCineplex.Data.Common.Models;

    public class Ticket : BaseDeletableModel<int>
    {
        public decimal Price { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public DateTime ProjectionStartDate { get; set; }

        public string MovieName { get; set; }

        public string CinemaName { get; set; }

        public int RoomNumber { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int ProjectionId { get; set; }

        public Projection Projection { get; set; }
    }
}
