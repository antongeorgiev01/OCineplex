using OCineplex.Data.Common.Models;

namespace OCineplex.Data.Models
{
    public class Seat : BaseDeletableModel<int>
    {
        public int HallId { get; set; }

        public Hall Hall { get; set; }

    }
}