namespace OCineplex.Web.ViewModels.Home
{
    using OCineplex.Data.Models;
    using OCineplex.Services.Mapping;

    public class IndexMovieViewModel : IMapFrom<Movie>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/m/{this.Title.Replace(' ', '-')}";
    }
}
