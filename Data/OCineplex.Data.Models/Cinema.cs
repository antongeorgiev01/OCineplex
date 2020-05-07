namespace OCineplex.Data.Models
{
    using System.Collections.Generic;

    using OCineplex.Data.Common.Models;

    public class Cinema : BaseDeletableModel<int>
    {
        public Cinema()
        {
            this.Halls = new HashSet<Hall>();
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Hall> Halls { get; set; }
    }
}
