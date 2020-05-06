namespace OCineplex.Web.ViewModels.Home
{
    public class IndexMovieViewModel
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public string Url => $"/m/{this.Name.Replace(' ', '-')}";
    }
}