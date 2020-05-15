namespace OCineplex.Web.ViewModels.Cinemas
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class CinemaCreateInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public IFormFile Picture { get; set; }
    }
}
