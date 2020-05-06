namespace OCineplex.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using OCineplex.Data;
    using OCineplex.Web.ViewModels;
    using OCineplex.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var movies = this.db.Movies.Select(x => new IndexMovieViewModel
            {
                Title = x.Title,
                Director = x.Director,
                ImageUrl = x.ImageUrl,
                Name = "GO",
            }).ToList();
            viewModel.Movies = movies;
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
