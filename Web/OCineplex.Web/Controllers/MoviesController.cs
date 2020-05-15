namespace OCineplex.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OCineplex.Services.Data;
    using OCineplex.Web.ViewModels.Movies;

    public class MoviesController : Controller
    {
        private readonly IMoviesService moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        public IActionResult ByTitle(string title)
        {
            var viewModel = this.moviesService.GetByTitle<MovieViewModel>(title.Replace('-', ' '));
            return this.View(viewModel);
        }
    }
}
