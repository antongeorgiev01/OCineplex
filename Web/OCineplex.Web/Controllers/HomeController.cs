namespace OCineplex.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using OCineplex.Data.Common.Repositories;
    using OCineplex.Data.Models;
    using OCineplex.Services.Data;
    using OCineplex.Services.Mapping;
    using OCineplex.Web.ViewModels;
    using OCineplex.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IMoviesService moviesService;

        public HomeController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var movies = this.moviesService.GetAll<IndexMovieViewModel>();
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
