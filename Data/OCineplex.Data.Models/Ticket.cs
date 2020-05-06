namespace OCineplex.Data.Models
{
    using OCineplex.Data.Common.Models;

    public class Ticket : BaseDeletableModel<int>
    {
        public decimal Price { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int ProjectionId { get; set; }

        public Projection Projection { get; set; }
    }
}
