namespace OCineplex.Services.Data
{
    using System.Threading.Tasks;

    public interface ICinemasService
    {
        Task<int> CreateAsync(string name, string address, string imageurl);
    }
}
