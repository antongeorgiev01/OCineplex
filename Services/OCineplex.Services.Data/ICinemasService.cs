namespace OCineplex.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICinemasService
    {
        Task<int> CreateAsync(string name, string address, string imageurl);

        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
